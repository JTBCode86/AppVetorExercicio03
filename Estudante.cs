namespace AppVetorExercicio03
{
    class Estudante
    {
        public string nomeEstudante { get; set; }

        public string emailEstudante { get; set; }

        public Estudante(string nome, string email)
        {
            this.nomeEstudante = nome;
            this.emailEstudante = email;
        }

        public override string ToString()
        {
            return nomeEstudante +", "+emailEstudante;
        }
    }
}
