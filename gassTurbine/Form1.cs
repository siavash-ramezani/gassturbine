using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace gassTurbine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            var x = GetDouble(InletPressureLoss);
            var powerG2 = Fx(
                new List<double> {
                   1.000000362,
                   (-1.454883055 * Power(3)),
                   (-2.093249020 * Power(5)),
                   (3.036622559 * Power(6)),
                   (-1.846395223 * Power(7)),
                   (3.906249962 *Power(9))
                }, x);
            var etaG2 = Fx(
                new List<double> {
                    1.000000340,
                    (-4.853168130 * Power(4)),
                    (-1.885599528 * Power(5)),
                    (2.814006464 * Power(6)),
                    (2.814006464 * Power(6)),
                    (-1.720754224 * Power(7)),
                    (3.662109352 * Power(9))
                }, x);

            x = GetDouble(OutletPressureLoss);
            var powerG3 = Fx(
                new List<double> {
                    1.000002028,
                    (-5.378305377*Power(4)),
                    (3.314685859*Power(7)),
                    (-3.567891260*Power(9)),
                    (-1.089743538*Power(10)),
                    (1.249999978*Power(12))
                }, x);
            var etaG3 = Fx(
                new List<double> {
                    1.000002028,
                    (-5.378305377 * Power(4)),
                    (3.314685859 * Power(7)),
                    (-3.567891260 * Power(9)),
                    (-1.089743538 * Power(10)),
                    (1.249999978 * Power(12))
                }, x);
            x = GetDouble(LHV);
            double etaG4 = 0;
            double powerG4 = 0;
            if (GetDouble(CH) == 3)
            {
                 powerG4 = Fx(
                    new List<double> {
                    1.312641449,
                    (-1.361944896 * Power(5)),
                    (2.032792823 * Power(10)),
                    (-1.120996331 *Power(15))
                }, x);
                etaG4 = Fx(
                 new List<double> {
                    1.007192068,
                    (-2.857634464 * Power(7)),
                    (3.704863153 * Power(12)),
                    (-1.794500076 * Power(17))
                 }, x);

            }
            else if (GetDouble(CH) == 3.5)
            {
                powerG4 = Fx(
                 new List<double> {
                    1.174944871,
                    (-5.815472309 *Power(6)),
                    (4.322072768 * Power(11))
                 }, x);

                etaG4 = Fx(
                new List<double> {
                    1.006891185,
                    (-5.111166928 * Power(7)),
                    (1.034404904 * Power(11)),
                    (-7.221545211 * Power(17))
                }, x);

            }
            else if (GetDouble(CH) == 4)
            {
                powerG4 = Fx(
                 new List<double> {
                    1.232380427,
                    (-1.052086054*Power(5)),
                    (1.532915045*Power(10)),
                    (-8.266867923*Power(16))
                 }, x);
                etaG4 = Fx(
               new List<double> {
                        (9.591417730 * Power(1)),
                        (2.978809775 * Power(6)),
                        (-8.889328968 * Power(11)),
                        (1.179051835 * Power(15))
               }, x);
            }
            else if (GetDouble(CH) == 4.5)
            {
                powerG4 = Fx(
                    new List<double> {
                        1.133463378,
                        (-4.823388556*Power(6)),
                        (3.563116427*Power(11))
                    }, x);
                etaG4 = Fx(
                    new List<double> {
                        (9.845960312 * Power(1)),
                        (5.683045899 * Power(7)),
                        (-1.020950367 * Power(11)),
                        (6.473513644 * Power(17))
                    }, x);

            }
            else if (GetDouble(CH) == 5)
            {
                powerG4 = Fx(
                  new List<double> {
                        1.191700824,
                        (-9.260454590*Power(6)),
                        (1.371740915*Power(10)),
                        (-7.543188384*Power(16))
                  }, x);
                etaG4 = (9.848113801 * Power(1)) * Pow(x, 0) + (4.209155762 * Power(7)) * Pow(x, 1) + (-6.106878079 * Power(12)) * Pow(x, 2) + (3.202600492 * Power(17)) * Pow(x, 3);

            }
            else if (GetDouble(CH) == 5.5)
            {
                powerG4 = Fx(
                  new List<double> {
                        1.134728554,
                        (-5.974898036*Power(6)),
                        (6.800367453*Power(11)),
                        (-2.568577889*Power(16))
                  }, x);
                etaG4 = (9.872759694 * Power(1)) * Pow(x, 0) + (1.492301554 * Power(7)) * Pow(x, 1) + (6.289089872 * Power(13)) * Pow(x, 2) + (-2.051407309 * Power(17)) * Pow(x, 3);

            }
            else if (GetDouble(CH) == 6)
            {
                powerG4 = Fx(
                     new List<double> {
                        1.120400128,
                        (-5.478251024*Power(6)),
                        (6.055887629*Power(11)),
                        (-2.152252488*Power(16))
                     }, x);
                etaG4 = (9.855869925 * Power(1)) * Pow(x, 0) + (1.587743832 * Power(7)) * Pow(x, 1) + (1.132310155 * Power(12)) * Pow(x, 2) + (-2.667217664 * Power(17)) * Pow(x, 3);

            }
            else if (GetDouble(CH) == 6.5)
            {
                powerG4 = Fx(
                    new List<double> {
                        1.106269769,
                        (-4.941033980*Power(6)),
                        (5.191445012*Power(11)),
                        (-1.642585112*Power(16))
                    }, x);
                etaG4 = (9.833876901 * Power(1)) * Pow(x, 0) + (2.124424880 * Power(7)) * Pow(x, 1) + (6.211411988 * Power(13)) * Pow(x, 2) + (-2.534014484 * Power(17)) * Pow(x, 3);

            }
            else if (GetDouble(CH) == 7)
            {
                powerG4 = Fx(
                    new List<double> {
                        1.102898575,
                        (-5.070672422*Power(6)),
                        (5.768063229*Power(11)),
                        (-2.183447544*Power(16))
                    }, x);
                etaG4 = (9.830112539 * Power(1)) * Pow(x, 0) + (1.575933844 * Power(7)) * Pow(x, 1) + (2.419468454 * Power(12)) * Pow(x, 2) + (-4.081396038 * Power(17)) * Pow(x, 3);

            }

            x = GetDouble(Humidity);
            double etaG5 = 0;
            double powerG5 = 0;
            if (GetDouble(Temperature) == -15)
            {
                powerG4 = Fx(
                     new List<double> {
                        (9.995794756 * Power(1)),
                        (1.909912325*Power(5)),
                        (-8.902243342*Power(7)),
                        (2.245046615*Power(8)),
                        (-2.376165497*Power(10)),
                        (8.974358935*Power(13))
                     }, x);
                etaG5 = (1) * x;
            }
            else if (GetDouble(Temperature) == 0)
            {
                powerG4 = Fx(
                    new List<double> {
                        (9.986004348 * Power(1)),
                        (2.721050276*Power(5)),
                        (-4.109543426*Power(7)),
                        (1.621369883*Power(8)),
                        (-2.944537877*Power(10)),
                        (2.489630301*Power(12)),
                        (-7.924836231*Power(15))
                    }, x);
                etaG5 = (1.000329983) * Pow(x, 0) + (-4.785754300 * Power(6)) * Pow(x, 1) + (-6.806961572 * Power(8)) * Pow(x, 2) + (2.358245904 * Power(9)) * Pow(x, 3) + (-3.270687670 * Power(11)) * Pow(x, 4) + (1.442307713 * Power(13)) * Pow(x, 5);
            }
            else if (GetDouble(Temperature) == 15)
            {
                powerG4 = Fx(
                    new List<double> {
                        (9.970493612 * Power(1)),
                        (4.451331426*Power(5)),
                        (1.032426759*Power(6)),
                        (-5.447874196*Power(8)),
                        (1.178975001*Power(9)),
                        (-1.131127391*Power(11)),
                        (3.978757953*Power(14))
                    }, x);
                etaG5 = (1.001346918) * Pow(x, 0) + (-1.355204745 * Power(6)) * Pow(x, 1) + (-1.844509349 * Power(6)) * Pow(x, 2) + (6.607817760 * Power(8)) * Pow(x, 3) + (-1.138361544 * Power(9)) * Pow(x, 4) + (9.276583733 * Power(12)) * Pow(x, 5) + (-2.877450988 * Power(14)) * Pow(x, 6);
            }
            else if (GetDouble(Temperature) == 30)
            {
                powerG4 = Fx(
                    new List<double> {
                        (9.948531785 * Power(1)),
                        (8.763877651*Power(5)),
                        (8.228351334*Power(8)),
                        (-3.141588767*Power(9)),
                        (6.403664404*Power(11)),
                        (-1.034125205*Power(12)),
                        (5.637254139*Power(15))
                    }, x);
                etaG5 = (1.004106763) * Pow(x, 0) + (-4.457568525 * Power(5)) * Pow(x, 1) + (-2.097213702 * Power(6)) * Pow(x, 2) + (7.624866649 * Power(8)) * Pow(x, 3) + (-1.325864071 * Power(9)) * Pow(x, 4) + (1.075886152 * Power(11)) * Pow(x, 5) + (-3.292483770 * Power(14)) * Pow(x, 6);
            }
            else if (GetDouble(Temperature) == 45)
            {
                powerG4 = Fx(
                    new List<double> {
                        (9.964636094 * Power(1)),
                        (8.273938028*Power(5)),
                        (1.216814930*Power(6)),
                        (-5.799579217*Power(8)),
                        (8.153746150*Power(10)),
                        (-6.243966553*Power(12)),
                        (2.089869271*Power(14))
                    }, x);
                etaG5 = (1.014099232) * Pow(x, 0) + (-2.304299123 * Power(4)) * Pow(x, 1) + (1.058186733 * Power(6)) * Pow(x, 2) + (-3.633523571 * Power(8)) * Pow(x, 3) + (4.508013407 * Power(10)) * Pow(x, 4) + (-3.413461625 * Power(12)) * Pow(x, 5) + (1.249999999 * Power(14)) * Pow(x, 6);
            }

            x = GetDouble(speed);
            double etaG6 = 0;
            if (GetDouble(Temperature) == -15)
            {
                if (x >= 0.95 && x <= 0.975)
                {
                     etaG6 = (6.363566816) * Power(-1) * Pow(x, 0) + (4.662665725 * Power(-1)) * Pow(x, 1) + (-9.572902322 * Power(-2)) * Pow(x, 2);

                }
                else if (x >= 0.975 && x <= 1)
                {
                     etaG6 = (1) * Pow(x, 0);

                }
                else if (x >= 1 && x <= 1.03)
                {
                     etaG6 = (9.677371085) * Power(-1) * Pow(x, 0) + (3.227381706 * Power(-1)) * Pow(x, 1) + (-2.904762328 * Power(-1)) * Pow(x, 2);

                }

            }
            else if (GetDouble(Temperature) == 0)
            {
                if (x >= 0.95 && x <= 0.975)
                {
                     etaG6 = ((-5.013339408) * Power(0)) * Pow(x, 0) + (1.202463208 * Power(1)) * Pow(x, 1) + (-6.011205044 * Power(0)) * Pow(x, 2);

                }
                else if (x >= 0.975 && x <= 1)
                {
                     etaG6 = ((-5.013339408) * Power(0)) * Pow(x, 0) + (1.202463208 * Power(1)) * Pow(x, 1) + (-6.011205044 * Power(0)) * Pow(x, 2);

                }
                else if (x >= 1 && x <= 1.03)
                {
                     etaG6 = ((-1.968380451) * Power(0)) * Pow(x, 0) + (6.006475627 * Power(0)) * Pow(x, 1) + (-3.038094997 * Power(0)) * Pow(x, 2);

                }
            }
            else if (GetDouble(Temperature) == 15)
            {
                if (x >= 0.95 && x <= 0.975)
                {
                     etaG6 = ((-5.990075342) * Power(0)) * Pow(x, 0) + (1.385230014 * Power(1)) * Pow(x, 1) + ((-6.862015467) * Power(0)) * Pow(x, 2);

                }
                else if (x >= 0.975 && x <= 1)
                {
                     etaG6 = ((-5.990075342) * Power(0)) * Pow(x, 0) + (1.385230014 * Power(1)) * Pow(x, 1) + ((-6.862015467) * Power(0)) * Pow(x, 2);

                }
                else if (x >= 1 && x <= 1.03)
                {
                     etaG6 = ((-4.578534365) * Power(-1)) * Pow(x, 0) + (2.886428416 * Power(0)) * Pow(x, 1) + ((-1.428571373) * Power(0)) * Pow(x, 2);

                }
            }
            else if (GetDouble(Temperature) == 30)
            {
                if (x >= 0.95 && x <= 0.975)
                {
                     etaG6 = ((-1.227327548) * Power(1)) * Pow(x, 0) + (2.630783991 * Power(1)) * Pow(x, 1) + ((-1.303453130) * Power(1)) * Pow(x, 2);

                }
                else if (x >= 0.975 && x <= 1)
                {
                     etaG6 = ((-1.227327548) * Power(1)) * Pow(x, 0) + (2.630783991 * Power(1)) * Pow(x, 1) + ((-1.303453130) * Power(1)) * Pow(x, 2);

                }
                else if (x >= 1 && x <= 1.03)
                {
                     etaG6 = ((-1.206066966) * Power(0)) * Pow(x, 0) + (4.215761602 * Power(0)) * Pow(x, 1) + ((-2.009523660) * Power(0)) * Pow(x, 2);

                }
            }
            else if (GetDouble(Temperature) == 45)
            {
                if (x >= 0.95 && x <= 0.975)
                {
                     etaG6 = ((-7.830925025) * Power(0)) * Pow(x, 0) + (1.663313594 * Power(1)) * Pow(x, 1) + ((-7.801691294) * Power(0)) * Pow(x, 2);

                }
                else if (x >= 0.975 && x <= 1)
                {
                     etaG6 = ((-7.830925025) * Power(0)) * Pow(x, 0) + (1.663313594 * Power(1)) * Pow(x, 1) + ((-7.801691294) * Power(0)) * Pow(x, 2);

                }
                else if (x >= 1 && x <= 1.03)
                {
                     etaG6 = ((-4.164967418) * Power(0)) * Pow(x, 0) + (9.689046681 * Power(0)) * Pow(x, 1) + ((-4.523809105) * Power(0)) * Pow(x, 2);

                }
            }

            x = GetDouble(AmbientTemperature);
            double etaG7 = 0;
            if (x >= 0 && x <= 50)
            {
                 etaG7 = (1.019426350) * Power(0) * Pow(x, 0) + (-1.107507161 * Power(-3)) * Pow(x, 1) + (-1.335738773 * Power(-5)) * Pow(x, 2) + (-2.744594241 * Power(-8)) * Pow(x, 3) + (1.093554292 * Power(-8)) * Pow(x, 4) + (-3.765947918 * Power(-10)) * Pow(x, 5) + (2.577080408 * Power(-12)) * Pow(x, 6);

            }
            else if (x >= -20 && x <= 0)
            {
                 etaG7 = (1.019427474) * Power(0) * Pow(x, 0) + (-6.818858119 * Power(-4)) * Pow(x, 1) + (-6.706401368 * Power(-5)) * Pow(x, 2) + (-2.975086497 * Power(-6)) * Pow(x, 3) + (-5.150172992 * Power(-8)) * Pow(x, 4);

            }
            var etaG10 = (1.000032588) * Power(0) * Pow(x, 0) + (-2.651010315 * Power(-6)) * Pow(x, 1) + (7.950919431 * Power(-11)) * Pow(x, 2) + (2.299530262 * Power(-14)) * Pow(x, 3) + (-2.672527760 * Power(-18)) * Pow(x, 4) + (8.836103476 * Power(-23)) * Pow(x, 5);


        }

        private double Power(int x)
        {
            return Pow(10, -x);
        }


        private double GetDouble(TextBox input)
        {
            return Convert.ToDouble(input.Text);
        }
        private double GetDouble(ComboBox input)
        {
            return Convert.ToDouble(input.SelectedValue);
        }
        private double Fx(List<double> constants, double x)
        {
            double sum = 0;
            for (int i = 0; i < constants.Count; i++)
            {
                sum = sum + constants[i] * Pow(x, i);
            }
            return sum;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
