using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramadolll.Entities
{
    class QuickResponse
    {
        /// <summary>
        /// Método que devuelve un la imagen generada
        /// El primer parámetro es la palabra(s) a convertir
        /// y el segundo parámetro es el nivel. Este parámetro  es muy importante
        /// </summary>
        /// <param name="input"></param>
        /// <param name="qrlevel"></param>
        /// <returns></returns>
        public Image QuickResponseGenerador(string input, int qrlevel)
        {

            //QRCodeEncoder qe = new QRCodeEncoder();

            //qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            //qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L; // - Using LOW for more storage

            //qe.QRCodeVersion = qrlevel;

            //System.Drawing.Bitmap bm = qe.Encode(input);

            //return bm;
            return null;

        }

    }
}
