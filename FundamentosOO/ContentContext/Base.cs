using FundamentosOO.NotificationContext;

namespace FundamentosOO.ContentContext{
    public class Base : Notifiable{
        
        public Base(){
            Id = Guid.NewGuid(); //Gerador de hash de 32 caracteres, a ideia é gerar o ID automaticamente. Muito com para utilicar com o banco de dados.
        }
        public Guid Id { get; set; }
    }
}