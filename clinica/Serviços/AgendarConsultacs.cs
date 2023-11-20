using clinica.Entidades.Exception;

namespace clinica.Serviços
{
    public class AgendarConsultacs
    {
        DateTime dataCnsulta;
        DateTime dataCancelamento;
        char cancelar;


        public void marcarConsulta(string paciente, DateTime data)
        {
            
            DateTime dataConsulta = new DateTime();
            DateTime dataCancelamento = new DateTime();

            data = dataConsulta;


            try

            {
                if (paciente != null || dataConsulta != null);

            }
            catch (ArithmeticException e)
            {
               throw new DomainException ("Valor invalido" + e.Message);

            }
            catch (FormatException e)
            {
              throw new DomainException("Formato de entrada invalido" + e.Message);

            }
        }
    }
}
