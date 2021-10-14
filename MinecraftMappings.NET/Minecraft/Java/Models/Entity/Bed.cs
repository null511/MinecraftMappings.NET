using MinecraftMappings.Internal.Models.Entity;
using SharpDX;
using System.Collections.Generic;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Bed : JavaEntityModel
    {
        public Bed() : base("Bed")
        {
            AddVersion("bed", "1.0.0")
                //.WithPath("entity/bed")
                .WithTextureSize(64, 64)
                .AddElement("head", element => {
                    element.Position = new Vector3(-8f, 9f, 0f);
                    element.Size = new Vector3(16f, 16f, 6f);
                    element.UV = Vector2.Zero;
                    element.RotationOrigin = new Vector3(0f, 9f, 0f);
                    element.RotationAngleX = 90;

                    element.Elements = new List<EntityElement> {
                        new EntityElement {
                            Name = "head_left_leg",
                            Position = new Vector3(5f, -16f, -32f),
                            Size = new Vector3(3f, 3f, 3f),
                            UV = new Vector2(50f, 18f),
                            RotationOrigin = new Vector3(0f, -7f, 0f),
                            RotationAngleX = 270,
                            RotationAngleZ = 180,
                        },
                        new EntityElement {
                            Name = "head_right_leg",
                            Position = new Vector3(29f, -16f, -8f),
                            Size = new Vector3(3f, 3f, 3f),
                            UV = new Vector2(50f, 18f),
                            RotationOrigin = new Vector3(0f, -7f, 0f),
                            RotationAngleX = 270,
                            RotationAngleZ = 90,
                        },
                    };
                })
                .AddElement("foot", element => {
                    element.Position = new Vector3(-8f, -7f, 0f);
                    element.Size = new Vector3(16f, 16f, 6f);
                    element.UV = new Vector2(0f, 22f);
                    element.RotationOrigin = new Vector3(0f, 9f, 0f);
                    element.RotationAngleX = 90;
                });
        }
    }
}
