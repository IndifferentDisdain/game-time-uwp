using System.ComponentModel.DataAnnotations;

namespace game_time_uwp.lib.Sync
{
    public enum SaveStatus
    {
        [Display(Description = "Not Available")]
        NotAvailable,
        [Display(Description = "Saved")]
        Saved,
        [Display(Description = "Saving...")]
        Saving,
        [Display(Description = "Error; please try again(?)")]
        Error
    }
}
