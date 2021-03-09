namespace DC.Application.Console
{
    /// <summary>
    /// Classe console responsável por chamada de APIs de criação de Usuário e Geração de Token para o usuário criado
    /// Auto: Marcelo Branco
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            var frm = new frmConsole();
            frm.ShowDialog();           
        }    
    }
}
