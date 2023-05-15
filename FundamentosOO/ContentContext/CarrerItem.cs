namespace FundamentosOO.ContentContext{

        public class CarrerItem{
        public CarrerItem(int order, string? title, string? descripiton, Course? course)
        {
            Order = order;
            Title = title;
            Descripiton = descripiton;
            Course = course;
        }

        public int Order { get; set; }
        public string? Title { get; set; }
        public string? Descripiton { get; set; }
        public Course? Course { get; set; }

    }
}