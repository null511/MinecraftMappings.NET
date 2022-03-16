using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Chicken : JavaEntityModel
    {
        public Chicken() : base("Chicken")
        {
            AddVersion("chicken", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -9f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 9f, -6f),
                        Size = new Vector3(4f, 6f, 3f),
                        UV = Vector2.Zero,
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -8f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Submodels.Add(new EntityElement {
                        Id = "rotation",
                        Translate = new Vector3(0f, 8f, 0f),
                        RotationAngleX = -90,
                        InvertAxisX = true,
                        InvertAxisY = true,

                        Boxes = {
                            new EntityElementCube {
                                Position = new Vector3(-3f, -4f, -3f),
                                Size = new Vector3(6f, 8f, 6f),
                                UV = new Vector2(0f, 9f),
                            },
                        },
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(-2f, -5f, -1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, 0f, -2f),
                        Size = new Vector3(3f, 5f, 3f),
                        UV = new Vector2(26f, 0f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(1f, -5f, -1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3f, 0f, -2f),
                        Size = new Vector3(3f, 5f, 3f),
                        UV = new Vector2(26f, 0f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.Part = "right_wing";
                    element.Translate = new Vector3(-4f, -11f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(3f, 7f, -3f),
                        Size = new Vector3(1f, 4f, 6f),
                        UV = new Vector2(24f, 13f),
                    });
                })
                .AddElement("left_wing", element => {
                    element.Part = "left_wing";
                    element.Translate = new Vector3(4f, -11f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 7f, -3f),
                        Size = new Vector3(1f, 4f, 6f),
                        UV = new Vector2(24f, 13f),
                    });
                })
                .AddElement("bill", element => {
                    element.Part = "bill";
                    element.Translate = new Vector3(0f, -9f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 11f, -8f),
                        Size = new Vector3(4f, 2f, 2f),
                        UV = new Vector2(14f, 0f),
                    });
                })
                .AddElement("chin", element => {
                    element.Part = "chin";
                    element.Translate = new Vector3(0f, -9f, 4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 9f, -7f),
                        Size = new Vector3(2f, 2f, 2f),
                        UV = new Vector2(14f, 4f),
                    });
                });
        }
    }
}
