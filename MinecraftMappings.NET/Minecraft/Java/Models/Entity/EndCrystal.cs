using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class EndCrystal : JavaEntityModel
    {
        public EndCrystal() : base("End Crystal")
        {
            AddVersion("end_crystal", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("base", element => {
                    element.Part = "base";
                    element.Translate = new Vector3(0f, -4f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "base_rotation",
                        Translate = new Vector3(0f, 2f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-6f, -2f, -6f),
                                Size = new Vector3(12f, 4f, 12f),
                                UV = new Vector2(0f, 16f),
                            },
                        },
                    });
                })
                .AddElement("cube", element => {
                    element.Part = "cube";
                    element.Translate = new Vector3(0f, -10f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = new Vector2(32f, 0f),
                    });
                })
                .AddElement("glass", element => {
                    element.Part = "glass";
                    element.Translate = new Vector3(0f, -10f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 6f, -4f),
                        Size = new Vector3(8f, 8f, 8f),
                        UV = Vector2.Zero,
                    });
                });
        }
    }
}
