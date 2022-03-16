using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class EvokerFangs : JavaEntityModel
    {
        public EvokerFangs() : base("Evoker Fangs")
        {
            AddVersion("evoker_fangs", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("base", element => {
                    element.Part = "base";
                    element.Translate = new Vector3(-5f, -12f, 5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -5f),
                        Size = new Vector3(10f, 12f, 10f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("upper_jaw", element => {
                    element.Part = "upper_jaw";
                    element.Translate = new Vector3(-2.5f, -26f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "upper_jaw_rotation",
                        Translate = new Vector3(0.5f, 19f, 0f),
                        RotationAngleX = -180,
                        RotationAngleY = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2f, -7f, -4f),
                                Size = new Vector3(4f, 14f, 8f),
                                UV = new Vector2(40f, 0f),
                            },
                        },
                    });
                })
                .AddElement("lower_jaw", element => {
                    element.Part = "lower_jaw";
                    element.Translate = new Vector3(-1.5f, -26f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "lower_jaw_rotation",
                        Translate = new Vector3(-0.5f, 19f, 0f),
                        RotationAngleX = -180,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2f, -7f, -4f),
                                Size = new Vector3(4f, 14f, 8f),
                                UV = new Vector2(40f, 0f),
                            },
                        },
                    });
                });
        }
    }
}
