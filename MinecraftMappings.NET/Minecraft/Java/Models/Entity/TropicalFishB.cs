using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class TropicalFishB : JavaEntityModel
    {
        public TropicalFishB() : base("Tropical Fish, B")
        {
            AddVersion("tropical_fish_b", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -3f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, 0f),
                        Size = new Vector3(2f, 6f, 6f),
                        UV = new Vector2(0f, 20f),
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "right_fin",
                        Translate = new Vector3(1f, 0f, 3f),
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
                        Translate = new Vector3(-1f, 0f, 3f),
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
                    element.Translate = new Vector3(0f, -6f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 6f, 0f),
                        Size = new Vector3(0f, 4f, 6f),
                        UV = new Vector2(20f, 11f),
                    });
                })
                .AddElement("fin_bottom", element => {
                    element.Part = "fin_bottom";
                    element.Translate = Vector3.Zero;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, -4f, 0f),
                        Size = new Vector3(0f, 4f, 6f),
                        UV = new Vector2(20f, 21f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -3f, -6f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, 6f),
                        Size = new Vector3(0f, 6f, 5f),
                        UV = new Vector2(21f, 16f),
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
