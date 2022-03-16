using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Skeleton
{
    public class StrayOverlay : JavaEntityTexture
    {
        public StrayOverlay() : base("Stray Overlay")
        {
            AddVersion("stray_overlay")
                .WithDefaultModel<Java.Models.Entity.Skeleton>();
                //.MapsToBedrockEntity<BedrockEntities.StrayOverlay>();
        }
    }
}
