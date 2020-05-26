namespace CadastroAluno
{
    public class aluno
    {
        public string nome;
        public int idade;
        public string rg;
        public bool bolsista;
        public float percentual;
        public float mediaFinal;
        public float valorMensalidade;
        /// <summary>
        /// Calcula a media final do aluno
        /// </summary>
        /// <returns>Valor da media do aluno (float)</returns>
        public float verMediaFinal(){
            return mediaFinal;
        }
       
       /// <summary>
       /// Calcula a mensalidade do aluno
       /// </summary>
       /// <returns>Valor da mensalidade paga (float)</returns>
        public float verMensalidade(){
            
            float valorCalculado = valorMensalidade;
                if(bolsista == true){
                    valorCalculado = valorMensalidade - (valorMensalidade * percentual /100);
                }
            return valorCalculado;

        }

           /// <summary>
           /// Traduz resposta para booleana
           /// </summary>
           /// <param name="condicao"></param>
           /// <returns></returns>
            public bool TraduzConsole(string condicao){
                if(condicao == "sim"){
                    bolsista = true;
                }else{
                    bolsista = false;

                }
                return bolsista;
            }
    }
}