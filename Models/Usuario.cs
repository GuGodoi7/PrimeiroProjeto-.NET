namespace RM99585.Models
{
    public class Usuario
    {
        private string Nome { get; set; }

        public String Email { get; set; }

        public string Senha { get; set; }

        public DateTime DataNascimento { get; set; }

        public void SetNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                throw new ArgumentNullException("O campo nome deve conter um valor");
            }
            else
            {
                Nome = nome;
            }

        }
        public string GetNome()
        {
            return Nome;
        }
    }
}
