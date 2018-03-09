using System.Collections.Generic;

namespace CSharpIntermediate_Interfaces
{
    class VideoEncoder
    {
        private readonly IList<INotificationService> _notificationService;
        public VideoEncoder()
        {
            _notificationService = new List<INotificationService>();
        }

        public void Encode(Video vid)
        {
            //Logic of encoding ...

            foreach (var item in _notificationService)
            {
                item.Send(new Message());
            }
        }

        public void Register(INotificationService notificationService)
        {
            _notificationService.Add(notificationService);
        }
    }
}
