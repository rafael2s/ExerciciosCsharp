namespace FundamentosOO.ContentContext{
    
    public class Carrer : Content{

        public Carrer(string title, string url) :base(title,url){

            Items = new List<CarrerItem>();
        }

        public IList<CarrerItem> Items { get; set; }
        //public int TotalCourses { 
        //    get{
        //        return Items.Count; 
        //    } 
        //}
        public int TotalCourses => Items.Count; // "=>" Expression Body (No caso TotalCourses get tem apneas 1 linha, tiramos a chaves e o get.)
    }
}