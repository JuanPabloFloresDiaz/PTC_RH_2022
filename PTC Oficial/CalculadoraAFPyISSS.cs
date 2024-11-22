using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTC_Oficial
{
    public partial class CalculadoraAFPyISSS : Form
    {
        public CalculadoraAFPyISSS()
        {
            InitializeComponent();
            cboPor.Items.Add("Año");
            cboPor.Items.Add("Mes");
            cboPor.Items.Add("Quincena");
            cboPor.Items.Add("Semana");
            cboPor.Items.Add("Dia");
            cboPor.SelectedIndex = 1;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n;
            n = Convert.ToDouble(txtIngresoBruto.Text);
            if (txtIngresoBruto.Text == "")
            {
                errorMATH.SetError(txtIngresoBruto, "Los campos estan vacios");
            }
            else if (n < 0)
            {
                errorMATH.SetError(txtIngresoBruto, "El numero es negativo, ingrese solo positivo");
            }
            else
            {
                if (cboPor.Text == "Mes")
                {
                    txtSalario.Text = txtIngresoBruto.Text;
                    double salario = double.Parse(txtSalario.Text);
                    double isss = salario * 0.03;
                    double afp = salario * 0.725;
                    double resultadoisssyafp = isss + afp;
                    double pagoneto = salario - resultadoisssyafp;
                    double tramos = salario;

                    double totalisss = Math.Round(isss, 2);
                    double totalafp = Math.Round(afp, 2);
                    double totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                    double totalpagoneto = Math.Round(pagoneto, 2);
                    txtISSS.Text = totalisss.ToString();
                    txtAFP.Text = totalafp.ToString();
                    txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                    txtPagoNeto.Text = totalpagoneto.ToString();
                    if (tramos > 0 && tramos <= 472.00)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        pagoneto = salario - resultadoisssyafp;

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = "No pagas renta";
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();

                    }
                    else if (tramos >= 472.01 && tramos <= 642.85)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 487.60;
                        double totalrenta = (cuotarenta2 * 0.10) + 17.48;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }

                    else if (tramos >= 642.86 && tramos <= 915.81)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 642.85;
                        double totalrenta = (cuotarenta2 * 0.10) + 32.40;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 915.82 && tramos <= 999.99)
                    {
                        isss = 30;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 895.24;
                        double totalrenta = (cuotarenta2 * 0.2) + 60;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 1000 && tramos <= 2038.10)
                    {
                        isss = 30;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 895.24;
                        double totalrenta = (cuotarenta2 * 0.20) + 60;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 2038.11)
                    {
                        isss = 30;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 2038.10;
                        double totalrenta = (cuotarenta2 * 0.20) + 288.57;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }

                }
                else if (cboPor.Text == "Quincena")
                {
                    txtSalario.Text = txtIngresoBruto.Text;
                    double salario = double.Parse(txtSalario.Text);
                    double isss = salario * 0.03;
                    double afp = salario * 0.725;
                    double resultadoisssyafp = isss + afp;
                    double pagoneto = salario - resultadoisssyafp;
                    double tramos = salario;

                    double totalisss = Math.Round(isss, 2);
                    double totalafp = Math.Round(afp, 2);
                    double totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                    double totalpagoneto = Math.Round(pagoneto, 2);
                    txtISSS.Text = totalisss.ToString();
                    txtAFP.Text = totalafp.ToString();
                    txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                    txtPagoNeto.Text = totalpagoneto.ToString();
                    if (tramos > 0 && tramos <= 236.00)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        pagoneto = salario - resultadoisssyafp;

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = "No pagas renta";
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos > 236.01 && tramos <= 321.42)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 243.80;
                        double totalrenta = (cuotarenta2 * 0.10) + 8.74;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 321.43 && tramos <= 457.90)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 321.42;
                        double totalrenta = (cuotarenta2 * 0.10) + 16.20;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 457.91 && tramos <= 499.99)
                    {
                        isss = 15;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 447.62;
                        double totalrenta = (cuotarenta2 * 0.2) + 30;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 500 && tramos <= 1019.05)
                    {
                        isss = 15;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 447.62;
                        double totalrenta = (cuotarenta2 * 0.2) + 30;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 1019.06)
                    {
                        isss = 15;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 1019.05;
                        double totalrenta = (cuotarenta2 * 0.2) + 144.28;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }

                }
                else if (cboPor.Text == "Semana")
                {
                    txtSalario.Text = txtIngresoBruto.Text;
                    double salario = double.Parse(txtSalario.Text);
                    double isss = salario * 0.03;
                    double afp = salario * 0.725;
                    double resultadoisssyafp = isss + afp;
                    double pagoneto = salario - resultadoisssyafp;
                    double tramos = salario;

                    double totalisss = Math.Round(isss, 2);
                    double totalafp = Math.Round(afp, 2);
                    double totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                    double totalpagoneto = Math.Round(pagoneto, 2);
                    txtISSS.Text = totalisss.ToString();
                    txtAFP.Text = totalafp.ToString();
                    txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                    txtPagoNeto.Text = totalpagoneto.ToString();
                    if (tramos > 0 && tramos <= 118.00)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        pagoneto = salario - resultadoisssyafp;

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = "No pagas renta";
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos > 118.01 && tramos <= 160.71)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 121.9;
                        double totalrenta = (cuotarenta2 * 0.10) + 4.37;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 160.72 && tramos <= 228.95)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 160.71;
                        double totalrenta = (cuotarenta2 * 0.10) + 8.10;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 228.96 && tramos <= 249.99)
                    {
                        isss = 7.50;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 223.81;
                        double totalrenta = (cuotarenta2 * 0.2) + 15;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 250 && tramos <= 509.52)
                    {
                        isss = 7.50;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 223.81;
                        double totalrenta = (cuotarenta2 * 0.2) + 15;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 509.53)
                    {
                        isss = 7.50;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 509.52;
                        double totalrenta = (cuotarenta2 * 0.2) + 72.14;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                }
                else if (cboPor.Text == "Año")
                {
                    txtSalario.Text = txtIngresoBruto.Text;
                    double salario = double.Parse(txtSalario.Text);
                    double isss = salario * 0.03;
                    double afp = salario * 0.725;
                    double resultadoisssyafp = isss + afp;
                    double pagoneto = salario - resultadoisssyafp;
                    double tramos = salario;

                    double totalisss = Math.Round(isss, 2);
                    double totalafp = Math.Round(afp, 2);
                    double totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                    double totalpagoneto = Math.Round(pagoneto, 2);
                    txtISSS.Text = totalisss.ToString();
                    txtAFP.Text = totalafp.ToString();
                    txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                    txtPagoNeto.Text = totalpagoneto.ToString();
                    if (tramos > 0 && tramos <= 5664.00)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        pagoneto = salario - resultadoisssyafp;

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = "No pagas renta";
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();

                    }
                    else if (tramos >= 5664.01 && tramos <= 7714.20)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 5851.20;
                        double totalrenta = (cuotarenta2 * 0.10) + 209.76;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }

                    else if (tramos >= 7714.21 && tramos <= 10989.72)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 7714.20;
                        double totalrenta = (cuotarenta2 * 0.10) + 388.80;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 10989.73 && tramos <= 11999.88)
                    {
                        isss = 360;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 10742.88;
                        double totalrenta = (cuotarenta2 * 0.2) + 720;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 11999.89 && tramos <= 24457.20)
                    {
                        isss = 360;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 10742.88;
                        double totalrenta = (cuotarenta2 * 0.20) + 720;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 24457.21)
                    {
                        isss = 360;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 24457.20;
                        double totalrenta = (cuotarenta2 * 0.20) + 3462.84;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }

                }
                else if (cboPor.Text == "Dia")
                {
                    txtSalario.Text = txtIngresoBruto.Text;
                    double salario = double.Parse(txtSalario.Text);
                    double isss = salario * 0.03;
                    double afp = salario * 0.725;
                    double resultadoisssyafp = isss + afp;
                    double pagoneto = salario - resultadoisssyafp;
                    double tramos = salario;

                    double totalisss = Math.Round(isss, 2);
                    double totalafp = Math.Round(afp, 2);
                    double totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                    double totalpagoneto = Math.Round(pagoneto, 2);
                    txtISSS.Text = totalisss.ToString();
                    txtAFP.Text = totalafp.ToString();
                    txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                    txtPagoNeto.Text = totalpagoneto.ToString();
                    if (tramos > 0 && tramos <= 16.86)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        pagoneto = salario - resultadoisssyafp;

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = "No pagas renta";
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos > 16.87 && tramos <= 22.96)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 17.41;
                        double totalrenta = (cuotarenta2 * 0.10) + 0.62;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 22.97 && tramos <= 32.71)
                    {
                        isss = salario * 0.03;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 22.96;
                        double totalrenta = (cuotarenta2 * 0.10) + 1.16;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);

                        totalisss = Math.Round(isss, 2);
                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = totalisss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 32.72 && tramos <= 35.71)
                    {
                        isss = 1.07;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 31.98;
                        double totalrenta = (cuotarenta2 * 0.2) + 2.14;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 35.72 && tramos <= 72.79)
                    {
                        isss = 1.07;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 31.98;
                        double totalrenta = (cuotarenta2 * 0.2) + 2.14;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                    else if (tramos >= 72.80)
                    {
                        isss = 1.07;
                        afp = (salario * 0.725 * 10) / 100;
                        resultadoisssyafp = afp + isss;
                        double cuotarenta1 = salario - resultadoisssyafp;
                        double cuotarenta2 = cuotarenta1 - 72.79;
                        double totalrenta = (cuotarenta2 * 0.2) + 10.30;
                        pagoneto = salario - (resultadoisssyafp + totalrenta);


                        totalafp = Math.Round(afp, 2);
                        totalresultadoisssyafp = Math.Round(resultadoisssyafp, 2);
                        double valortotalrenta = Math.Round(totalrenta, 2);
                        totalpagoneto = Math.Round(pagoneto, 2);

                        txtISSS.Text = isss.ToString();
                        txtAFP.Text = totalafp.ToString();
                        txtRenta.Text = valortotalrenta.ToString();
                        txtImpuestoTotal.Text = totalresultadoisssyafp.ToString();
                        txtPagoNeto.Text = totalpagoneto.ToString();
                    }
                }
            }
        }

        private void txtIngresoBruto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                errorMATH.SetError(txtIngresoBruto, "Ingresar valor numerico");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtIngresoBruto.Clear();
            txtSalario.Clear();
            txtISSS.Clear();
            txtAFP.Clear();
            txtRenta.Clear();
            txtImpuestoTotal.Clear();
            txtPagoNeto.Clear();
        }

        private void CalculadoraAFPyISSS_Load(object sender, EventArgs e)
        {
            if (Menu_Admin.COLORES == "Defecto")
            {
                TemaColores.ElegirTema("Defecto");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Rojo")
            {
                TemaColores.ElegirTema("Rojo");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Azul")
            {
                TemaColores.ElegirTema("Azul");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Verde")
            {
                TemaColores.ElegirTema("Verde");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Amarillo")
            {
                TemaColores.ElegirTema("Amarillo");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Cafe")
            {
                TemaColores.ElegirTema("Cafe");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
            else if (Menu_Admin.COLORES == "Morado")
            {
                TemaColores.ElegirTema("Morado");
                this.BackColor = TemaColores.PanelContenedor;
                lblISSS.ForeColor = TemaColores.letra;
                lblAFP.ForeColor = TemaColores.letra;
                lblImpuestosTotales.ForeColor = TemaColores.letra;
                lblIngresar.ForeColor = TemaColores.letra;
                lblPagoNeto.ForeColor = TemaColores.letra;
                lblSalario.ForeColor = TemaColores.letra;
                lblTitulo.ForeColor = TemaColores.letra;
                lblValorDeFecha.ForeColor = TemaColores.letra;
                lblRenta.ForeColor = TemaColores.letra;
            }
        }
    }
}
