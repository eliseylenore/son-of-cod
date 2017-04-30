using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SonOfCod.Models
{
    [Table("MarketingPages")]
    public class MarketingPage
    {
        [Key]
        public int Id { get; set; }
        public string BannerImageUrl { get; set; } = "https://hginthesea.files.wordpress.com/2011/11/img_0291.jpg";
        public string BannerTitle { get; set; } = "May Cod Be With You.";
        public string SummaryTitle { get; set; } = "Cod Bless";
        public string SummaryText { get; set; } = "Dusky grouper, tommy ruff pineconefish croaker, Atlantic eel Redfin perch hillstream loach mudsucker ilisha, wolffish, central mudminnow. Mahi-mahi, eel cod jewel tetra: shark fire bar danio greenling sand goby scabbard fish chain pickerel bent-tooth smoothtongue bull shark? Priapumfish mahi-mahi snake eel New Zealand sand diver. Darter bichir gianttail gar ghost pipefish. Denticle herring velvetfish needlefish electric eel--parrotfish velvet catfish smelt-whiting. Yellowtail snapper three spot gourami, whiptail gulper. Longnose dace candiru grideye deep sea bonefish lancetfish sand tiger.";
        public string SummaryImageUrl { get; set; } = "https://www.pacseafood.com/images/librariesprovider3/default-album/product-line.jpg?sfvrsn=0";
        public string ProductsTitle { get; set; } = "Our Products";
        public string NewsTitle { get; set; } = "News & Stuff";
        public string NewsSummary { get; set; } = "Warty angler large-eye bream gar graveldiver four-eyed fish buri, yellowmargin triggerfish glass catfish northern lampfish discus graveldiver; sábalo. Hake butterfly ray giant wels scorpionfish: pompano dolphinfish combtail gourami saury roughy rough sculpin, Japanese eel, sucker. Herring smelt pompano dolphinfish clown triggerfish crappie, powen rocket danio: bandfish. Alooh pompano marblefish, grunion yellowfin tuna, snipe eel mojarra. White croaker bull trout, bamboo shark collared dogfish marine hatchetfish searobin Oregon chub. Prickly shark Billfish flier dwarf gourami elver Asiatic glassfish whale shark. Wrasse lanternfish; snipe eel, gray eel-catfish barred danio yellow jack. Oldwife, rough scad redside pink salmon scissor-tail rasbora European minnow, bleak blue catfish.";
        public string NewsImageUrl { get; set; }  = "http://northwestseafood.com/wp-content/uploads/2015/12/dreamstime_xl_38406132-1030x687.jpg";
    }
}
