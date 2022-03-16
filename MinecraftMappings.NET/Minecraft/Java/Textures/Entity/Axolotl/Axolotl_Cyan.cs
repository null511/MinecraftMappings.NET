using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Axolotl
{
    public class Axolotl_Cyan : JavaEntityTexture
    {
        public Axolotl_Cyan() : base("Axolotl, Cyan")
        {
            AddVersion("axolotl_cyan")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Axolotl>();
                //.MapsToBedrockEntity<BedrockEntities.Axolotl_Cyan>();
        }
    }
}
