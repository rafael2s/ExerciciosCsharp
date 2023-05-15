namespace FundamentosOO.NotificationContext{

    public abstract class Notifiable{
        
        public List<Notification> Notifications { get; set; }

            public void AddRange(IEnumerable<Notification> notification){
                Notifications.AddRange(notification);
            }
    }
}