using OperacionesConPrimos;
using PEGeneral;

namespace Problema0007
{
    public partial class Form0007 : FormPE
    {
        protected int lugar;

        public Form0007()
        {
            InitializeComponent();
        }

        protected override void MiPanelTomarDatos()
        {
            miPanel = panel0007TomarDatos1;
        }

        protected override void EscribirEnunciado()
        {
            panelEnunciado1.CambiarEnunciado(
                $"By listing the first six prime numbers: 2, 3, 5, 7, 11 and 13, we can see that the 6th prime is 13.{Environment.NewLine}" +
                "What is the 10001st prime number?");
        }

        protected override void AsociarDatos()
        {
            lugar = (int)panel0007TomarDatos1.ValorCombo;
        }

        protected override void Resolver()
        {
            solucion = Primos.NsimoPrimo(lugar - 1);
        }

        protected override string LaSolucion()
        {
            return $"{solucion}";
        }
    }
}
