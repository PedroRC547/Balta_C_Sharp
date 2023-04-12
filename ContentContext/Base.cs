using Balta.NotificationContext;

namespace Balta.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; } //Guid é um global id um identificador global
    }


}