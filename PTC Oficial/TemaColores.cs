using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PTC_Oficial
{
    public static class TemaColores
    {
        public static Color PanelContenedor;
        public static Color PanelMenu;
        public static Color PanelSubMenu;
        public static Color PanelFormularioPadre;
        public static Color botones;
        public static Color botones2;
        public static Color letra;
        //Colores defecto
        private static readonly Color PanelContenedorD = Color.Turquoise;
        private static readonly Color PanelMenuD = Color.LightSeaGreen;
        private static readonly Color PanelSubMenuD = Color.MediumTurquoise;
        private static readonly Color PanelFormularioPadreD = Color.PaleTurquoise;
        public static readonly Color botonesD = Color.Transparent;
        public static readonly Color botones2D = Color.Aquamarine;
        public static readonly Color letraD = Color.Black;
        //Colores azules
        private static readonly Color PanelContenedorA = Color.MidnightBlue;
        private static readonly Color PanelMenuA = Color.DarkBlue;
        private static readonly Color PanelSubMenuA = Color.Snow;
        private static readonly Color PanelFormularioPadreA = Color.SkyBlue;
        public static readonly Color botonesA = Color.Transparent;
        public static readonly Color botones2A = Color.MediumBlue;
        public static readonly Color letraA = Color.White;
        //Colores amarillos
        private static readonly Color PanelContenedorY = Color.Goldenrod;
        private static readonly Color PanelMenuY = Color.DarkGoldenrod;
        private static readonly Color PanelSubMenuY = Color.Snow;
        private static readonly Color PanelFormularioPadreY = Color.Goldenrod;
        public static readonly Color botonesY = Color.Transparent;
        public static readonly Color botones2Y = Color.LightYellow;
        public static readonly Color letraY = Color.Black;
        //Colores rojos
        private static readonly Color PanelContenedorR = Color.DarkRed;
        private static readonly Color PanelMenuR = Color.Firebrick;
        private static readonly Color PanelSubMenuR = Color.PaleVioletRed;
        private static readonly Color PanelFormularioPadreR = Color.Salmon;
        public static readonly Color botonesR = Color.Transparent;
        public static readonly Color botones2R = Color.MediumVioletRed;
        public static readonly Color letraR = Color.White;
        //Colores verdes
        private static readonly Color PanelContenedorV = Color.DarkGreen;
        private static readonly Color PanelMenuV = Color.ForestGreen;
        private static readonly Color PanelSubMenuV = Color.Snow;
        private static readonly Color PanelFormularioPadreV = Color.MediumSeaGreen;
        public static readonly Color botonesV = Color.Transparent;
        public static readonly Color botones2V = Color.Green;
        public static readonly Color letraV = Color.White;
        //Colores morados
        private static readonly Color PanelContenedorM = Color.PaleVioletRed;
        private static readonly Color PanelMenuM = Color.DarkMagenta;
        private static readonly Color PanelSubMenuM = Color.Snow;
        private static readonly Color PanelFormularioPadreM = Color.PaleVioletRed;
        public static readonly Color botonesM = Color.Transparent;
        public static readonly Color botones2M = Color.Purple;
        public static readonly Color letraM = Color.White;
        //Colores cafes
        private static readonly Color PanelContenedorK = Color.SaddleBrown;
        private static readonly Color PanelMenuK = Color.Goldenrod;
        private static readonly Color PanelSubMenuK = Color.Snow;
        private static readonly Color PanelFormularioPadreK = Color.NavajoWhite;
        public static readonly Color botonesK = Color.Transparent;
        public static readonly Color botones2K = Color.Chocolate;
        public static readonly Color letraK = Color.White;
        public static void ElegirTema(string Tema)
        {
            if (Tema == "Defecto")
            {
                PanelContenedor = PanelContenedorD;
                PanelMenu = PanelMenuD;
                PanelSubMenu = PanelSubMenuD;
                PanelFormularioPadre = PanelFormularioPadreD;
                botones = botonesD;
                botones2 = botones2D;
                letra = letraD;
            }
            if (Tema == "Azul")
            {
                PanelContenedor = PanelContenedorA;
                PanelMenu = PanelMenuA;
                PanelSubMenu = PanelSubMenuA;
                PanelFormularioPadre = PanelFormularioPadreA;
                botones = botonesA;
                botones2 = botones2A;
                letra = letraA;
            }
            if (Tema == "Amarillo")
            {
                PanelContenedor = PanelContenedorY;
                PanelMenu = PanelMenuY;
                PanelSubMenu = PanelSubMenuY;
                PanelFormularioPadre = PanelFormularioPadreY;
                botones = botonesY;
                botones2 = botones2Y;
                letra = letraY;
            }
            if (Tema == "Rojo")
            {
                PanelContenedor = PanelContenedorR;
                PanelMenu = PanelMenuR;
                PanelSubMenu = PanelSubMenuR;
                PanelFormularioPadre = PanelFormularioPadreR;
                botones = botonesR;
                botones2 = botones2R;
                letra = letraR;
            }
            if (Tema == "Verde")
            {
                PanelContenedor = PanelContenedorV;
                PanelMenu = PanelMenuV;
                PanelSubMenu = PanelSubMenuV;
                PanelFormularioPadre = PanelFormularioPadreV;
                botones = botonesV;
                botones2 = botones2V;
                letra = letraV;
            }
            if (Tema == "Cafe")
            {
                PanelContenedor = PanelContenedorK;
                PanelMenu = PanelMenuK;
                PanelSubMenu = PanelSubMenuK;
                PanelFormularioPadre = PanelFormularioPadreK;
                botones = botonesK;
                botones2 = botones2K;
                letra = letraK;
            }
            if (Tema == "Morado")
            {
                PanelContenedor = PanelContenedorM;
                PanelMenu = PanelMenuM;
                PanelSubMenu = PanelSubMenuM;
                PanelFormularioPadre = PanelFormularioPadreM;
                botones = botonesM;
                botones2 = botones2M;
                letra = letraM;
            }
        }
    }
}
