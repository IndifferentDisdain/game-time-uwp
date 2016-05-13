using Microsoft.Azure.Mobile.Server;

namespace game_time_uwp.mobile_app_backend.DataObjects
{
    public class TodoItem : EntityData
    {
        public string Text { get; set; }

        public bool Complete { get; set; }
    }
}