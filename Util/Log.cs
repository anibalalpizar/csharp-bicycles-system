using System;
using System.Data.SqlClient;
using System.Text;

namespace ProyectoProgramadolll.Util
{
    public class Log
    {


        private static readonly log4net.ILog _MyLogControlEventos =
        log4net.LogManager.GetLogger("MyControlEventos");

        public static void LogException(Exception ex)
        {
            string texto = CreateGenericErrorExceptionDetail(ex);

            // Log4NET
            _MyLogControlEventos.Error(texto);

        }

        public static void LogException(SqlException ex)
        {
            string texto = CreateSQLExceptionsErrorDetails(ex);

            // Log4NET
            _MyLogControlEventos.Error(texto);
        }

        static string CreateGenericErrorExceptionDetail(Exception pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("Message    :{0}\n", pExcepcion.Message);
            msg.AppendFormat("Source     :{0}\n", pExcepcion.Source);
            msg.AppendFormat("StackTrace :{0}\n", pExcepcion.StackTrace);

            if (pExcepcion.InnerException != null)
            {
                msg.AppendFormat("InnerException Message    :{0}\n", pExcepcion.InnerException.Message);
                msg.AppendFormat("InnerException Source     :{0}\n", pExcepcion.InnerException.Source);
                msg.AppendFormat("InnerException StackTrace :{0}\n", pExcepcion.InnerException.StackTrace);
            }
            msg.AppendFormat("{0}\n", "".PadRight(100, '-'));
            return msg.ToString();
        }

        static string CreateSQLExceptionsErrorDetails(SqlException pExcepcion)
        {
            StringBuilder msg = new StringBuilder();

            msg.AppendFormat("\n");
            msg.AppendFormat("Lista de Errores \n");
            for (int i = 0; i < pExcepcion.Errors.Count; i++)
            {
                msg.AppendFormat("\t{0} de {1}\n", i + 1, pExcepcion.Errors.Count);
                msg.AppendFormat("\tNumber    : {1}\n", i + 1, pExcepcion.Errors[i].Number);
                msg.AppendFormat("\tLineNumber: {1}\n", i + 1, pExcepcion.Errors[i].LineNumber);
                msg.AppendFormat("\tMessage   : {1}\n", i + 1, pExcepcion.Errors[i].Message);

            }
            msg.AppendFormat("\n");
            msg.AppendFormat("StackTrace     {0}\n", pExcepcion.StackTrace);
            msg.AppendFormat(@"Info de errores para investigar mas https://technet.microsoft.com/en-us/library/cc645603(v=sql.105).aspx");
            return msg.ToString();
        }
    }
}
