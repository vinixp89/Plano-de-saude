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


            if ( paciente != null || dataConsulta != null) 
            
            {
                Console.WriteLine("digite um nome ou data válido");

                

            }
        }
    }
}
