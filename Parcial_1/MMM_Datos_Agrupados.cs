using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEFI_Est
{
    internal class MMM_Datos_Agrupados
    {
        public decimal Moda(decimal limiteInferior, decimal frecAbsInterModal, decimal frecAbsInterModalAnterior,
                                decimal frecAbsInterModalPosterior, decimal amplitudIntervalo)
        {
            decimal moda = limiteInferior + ((frecAbsInterModal - frecAbsInterModalAnterior) / 
                ((frecAbsInterModal - frecAbsInterModalAnterior) + (frecAbsInterModal - frecAbsInterModalPosterior))) * amplitudIntervalo;
            return moda;
        }

        public decimal Media(decimal limiteInferior, decimal frecuenciaAbsAcumulada,
                                 decimal frecAcumuladaInterModalAnterior, decimal frecuenciaAbsInterMedia,
                                 decimal amplitudIntervalo)
        {
            decimal media = limiteInferior + 
                            (((frecuenciaAbsAcumulada/2) - frecAcumuladaInterModalAnterior) / 
                                frecuenciaAbsInterMedia) * 
                                amplitudIntervalo;

            return media;
        }

    }
}
