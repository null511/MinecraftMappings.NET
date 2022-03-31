using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Minecraft.Bedrock.Models.Entities
{
    public class ChestNormal : BedrockEntityModel
    {
        public ChestNormal() : base("Chest, Normal")
        {
            AddVersion("chest_normal", "1.0.0")
                .WithTextureSize(64, 64)
                .AddUVMapping("lid", part => part
                    .AddFace(ElementFaces.Down,  14,  0, 14, 14)
                    .AddFace(ElementFaces.Up,    28,  0, 14, 14)
                    .AddFace(ElementFaces.West,   0, 14, 14,  5)
                    .AddFace(ElementFaces.South, 14, 14, 14,  5)
                    .AddFace(ElementFaces.East,  28, 14, 14,  5)
                    .AddFace(ElementFaces.North, 42, 14, 14,  5)
                )
                .AddUVMapping("base", part => part
                    .AddFace(ElementFaces.Down,  14, 19, 14, 14)
                    .AddFace(ElementFaces.Up,    28, 19, 14, 14)
                    .AddFace(ElementFaces.West,   0, 33, 14, 10)
                    .AddFace(ElementFaces.South, 14, 33, 14, 10)
                    .AddFace(ElementFaces.East,  28, 33, 14, 10)
                    .AddFace(ElementFaces.North, 42, 33, 14, 10)
                )
                .AddUVMapping("knob", part => part
                    .AddFace(ElementFaces.Down,  1, 0, 2, 1)
                    .AddFace(ElementFaces.Up,    3, 0, 2, 1)
                    .AddFace(ElementFaces.West,  0, 1, 1, 4)
                    .AddFace(ElementFaces.South, 1, 1, 2, 4)
                    .AddFace(ElementFaces.East,  3, 1, 1, 4)
                    .AddFace(ElementFaces.North, 4, 1, 2, 4)
                );
        }
    }
}
