using FundamentosOO.NotificationContext;
using FundamentosOO.SharedContext;

namespace FundamentosOO.ContentContext{

        public class CarrerItem : Base{
        public CarrerItem(int order, string? title, string? descripiton, Course? course)
        {

            if(course == null)
                AddNotification(new Notification("Course", "Curso inválido"));

            Order = order;
            Title = title;
            Descripiton = descripiton;
            Course = course;
        }

        public int Order { get; set; }
        public string? Title { get; set; }
        public string? Descripiton { get; set; }
        public Course Course { get; set; }

    }
}