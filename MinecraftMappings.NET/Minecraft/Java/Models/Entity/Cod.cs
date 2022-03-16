using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Cod : JavaEntityModel
    {
        public Cod() : base("Cod")
        {
            AddVersion("cod", "1.0.0")
                .WithTextureSize(32, 32)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -2f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, 0f),
                        Size = new Vector3(2f, 4f, 7f),
                        UV = Vector2.Zero,
                    });

                    element.Submodels.Add(new EntityElement {
                        Id = "right_fin",
                        Translate = new Vector3(1f, 1f, 0f),
                        RotationAngleZ = -45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(0f, 0f, -1f),
                                Size = new Vector3(2f, 0f, 2f),
                                UV = new Vector2(24f, 1f),
                            },
                        },
                    });
                    element.Submodels.Add(new EntityElement {
                        Id = "left_fin",
                        Translate = new Vector3(-1f, 1f, 0f),
                        RotationAngleZ = 45f,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-2f, 0f, -1f),
                                Size = new Vector3(2f, 0f, 2f),
                                UV = new Vector2(24f, 4f),
                            },
                        },
                    });
                })
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -2f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 0f, -3f),
                        Size = new Vector3(2f, 4f, 3f),
                        UV = new Vector2(11f, 0f),
                    });
                })
                .AddElement("nose", element => {
                    element.Part = "nose";
                    element.Translate = new Vector3(0f, -2f, 3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 1f, -4f),
                        Size = new Vector3(2f, 3f, 1f),
                        UV = new Vector2(0f, 0f),
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
                })
                .AddElement("fin_back", element => {
                    element.Part = "fin_back";
                    element.Translate = new Vector3(0f, -4f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 4f, -1f),
                        Size = new Vector3(0f, 1f, 6f),
                        UV = new Vector2(20f, -6f),
                    });
                })
                .AddElement("tail", element => {
                    element.Part = "tail";
                    element.Translate = new Vector3(0f, -2f, -7f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, 7f),
                        Size = new Vector3(0f, 4f, 4f),
                        UV = new Vector2(22f, 3f),
                    });
                });
        }
    }
}
