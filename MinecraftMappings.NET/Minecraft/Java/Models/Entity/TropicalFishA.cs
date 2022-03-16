using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class TropicalFishA : JavaEntityModel
    {
        public TropicalFishA() : base("Tropical Fish, A")
        {
            AddVersion("tropical_fish_a", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -1.5f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, -3f),
                        Size = new Vector3(2f, 3f, 6f),
                        UV = Vector2.Zero,
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "right_fin",
                        Translate = new Vector3(1f, 0f, 0f),
                        RotationAngleY = -45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, 0f, 0f),
                                Size = new Vector3(2f, 2f, 0f),
                                UV = new Vector2(2f, 16f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_fin",
                        Translate = new Vector3(-1f, 0f, 0f),
                        RotationAngleY = 45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2f, 0f, 0f),
                                Size = new Vector3(2f, 2f, 0f),
                                UV = new Vector2(2f, 12f),
                            },
                        },
                    });
                })
                .AddElement("fin_top", element => {
                    element.Part = "fin_top";
                    element.Translate = new Vector3(0f, -3f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 3f, -3f),
                        Size = new Vector3(0f, 4f, 6f),
                        UV = new Vector2(10f, -6f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -1.5f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, 3f),
                        Size = new Vector3(0f, 3f, 4f),
                        UV = new Vector2(24f, -4f),
                    });
                })
                .AddElement("fin_left", element => {
                    element.Part = "fin_left";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                })
                .AddElement("fin_right", element => {
                    element.Part = "fin_right";
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;
                });
        }
    }
}
