namespace FundamentosOO.ContentContext{

    public abstract class Content{

        public Content(){
            Id = Guid.NewGuid(); //Gerador de hash de 32 caracteres, a ideia é gerar o ID automaticamente. Muito com para utilicar com o banco de dados.
        }
        public Guid Id { get; set; }

        public string? Title { get; set; }   

        public string? Url { get; set; } 
    }
}