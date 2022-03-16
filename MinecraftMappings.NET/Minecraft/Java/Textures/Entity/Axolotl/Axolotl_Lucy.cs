using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Axolotl
{
    public class Axolotl_Lucy : JavaEntityTexture
    {
        public Axolotl_Lucy() : base("Axolotl, Lucy")
        {
            AddVersion("axolotl_lucy")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Axolotl>();
                //.MapsToBedrockEntity<BedrockEntities.Axolotl_Lucy>();
        }
    }
}
