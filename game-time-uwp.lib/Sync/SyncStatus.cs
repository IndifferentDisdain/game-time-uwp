using System.ComponentModel.DataAnnotations;

namespace game_time_uwp.lib.Sync
{
    public enum SyncStatus
    {
        [Display(Description = "Need to sync.")]
        NeedToSync,
        [Display(Description = "Syncing...")]
        Syncing,
        [Display(Description = "Up to date.")]
        Synced,
        [Display(Description = "Error. Offline?")]
        Error
    }
}
