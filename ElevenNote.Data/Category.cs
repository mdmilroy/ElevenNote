using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public Guid OwnerId { get; set; }
    }
}

// Bearer ObPhSmr2XiwdFJEnBIju7HsuKujzYWwX7t4zM-OgbHNsCcvNKuH8bg_F0q9_VJfnY2gWmCAQg21AV0VXhyM-AtfkZ62UdzKD1OIYnQc9IWEdgFxTccSJBcoKHTygFOLHXoQR91PQoTC5QTMC7RjCxXdpOLwgfOXSM34tHZaJX9g80Gj8W0jRWOzmGs9oxQW4s13rr-dDc2gTX2Mx6rmfpGQuXBHD9rfGoNAL_2nmlPJsl-PaJzmFPFv0f3SH_XR7vThqDCDmxddZwTOexNo4tlwIhw2QG3o3jF4BtZOM_DkqQ15FTJcFkSm86k0f61c3qydXI_VkwHvARaGWEJdRCsTvkMvzdLje5RrPLxS3MYWB2vzPNb_L5eXKtg1sLYKpHM3u1zTJfZbHDaPvWxTgvO1PIxtj9DluyFcxtXk5B8RIOU8RQ6D3CNQO8BrbV5TitUvTRbygjPtyTd686GTuUdhbCbhsSnWQUR2OjV7NrahKQrm8_39I17ebHrnTlOEo