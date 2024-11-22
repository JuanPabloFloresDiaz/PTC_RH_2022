using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC_Oficial
{
    public partial class TipoRC : Form
    {
        //Campos
        private int borderRadius = 23;
        private int borderSize = 2;
        private Color borderColor = Color.DimGray;
        public TipoRC()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelBarradetitulo.BackColor = borderColor;
            this.BackColor = borderColor;
        }
        //Arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TipoRC_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Metodos privados para redondear el formulario...
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }
        //Evento de los metodos
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectform = this.ClientRectangle;
            int mWidth = rectform.Width / 2;
            int mHeigth = rectform.Height / 2;
            var fbColors = GetFormBoundsColors();

            //Superior izquierdo
            DrawPath(rectform, e.Graphics, fbColors.TopLeftColor);
            //Superior derecho
            Rectangle rectTopRight = new Rectangle(mWidth, rectform.Y, mWidth, mHeigth);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);
            //Inferior izquierdo
            Rectangle rectBottomLeft = new Rectangle(rectform.X, rectform.Y + mHeigth, mWidth, mHeigth);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);
            //Inferior derecho
            Rectangle rectBottomRight = new Rectangle(mWidth, rectform.Y + mHeigth, mWidth, mHeigth);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
        }

        private void TipoRC_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        //Minimizar formulario desde la barra de tareas
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        private void panelBarradetitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TipoRC_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void TipoRC_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void TipoRC_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContenedor, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
            ventanaLogin.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }

        private void btnPreguntasfrecuentes_Click(object sender, EventArgs e)
        {
            RecuperarContraseñaPF ventanaRPC = new RecuperarContraseñaPF();
            ventanaRPC.Show();
            ventanaRPC.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            RCMail ventanaRPC = new RCMail();
            ventanaRPC.Show();
            ventanaRPC.FormClosed += delegate
            {
                Show();
            };
            Hide();
        }
    }
}
