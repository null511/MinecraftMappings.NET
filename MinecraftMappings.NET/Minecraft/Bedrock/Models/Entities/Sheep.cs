using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Minecraft.Bedrock.Models.Entities
{
    public class Sheep : BedrockEntityModel
    {
        public Sheep() : base("Sheep")
        {
            AddVersion("sheep", "1.0.0")
                .WithTextureSize(64, 64)
                .AddUVMapping("head", part => part
                    .AddFace(ElementFaces.Up,     8, 0, 6, 8)
                    .AddFace(ElementFaces.Down,  14, 0, 6, 8)
                    .AddFace(ElementFaces.East,   0, 8, 8, 6)
                    .AddFace(ElementFaces.North,  8, 8, 6, 6)
                    .AddFace(ElementFaces.West,  14, 8, 8, 6)
                    .AddFace(ElementFaces.South, 22, 8, 6, 6)
                )
                .AddUVMapping("leg1", part => part
                    .AddFace(ElementFaces.Up,    34,  8, 9,  6)
                    .AddFace(ElementFaces.Down,  43,  8, 9,  6)
                    .AddFace(ElementFaces.East,  28, 14, 6, 16)
                    .AddFace(ElementFaces.North, 34, 14, 8, 16)
                    .AddFace(ElementFaces.West,  42, 14, 6, 16)
                    .AddFace(ElementFaces.South, 48, 14, 8, 16)
                )
                .AddUVMapping("leg_fur", part => part
                    .AddFace(ElementFaces.Up,    34, 40, 9,  6)
                    .AddFace(ElementFaces.Down,  43, 40, 9,  6)
                    .AddFace(ElementFaces.East,  28, 46, 6, 16)
                    .AddFace(ElementFaces.North, 34, 46, 8, 16)
                    .AddFace(ElementFaces.West,  42, 46, 6, 16)
                    .AddFace(ElementFaces.South, 48, 46, 8, 16)
                );
        }
    }
}
