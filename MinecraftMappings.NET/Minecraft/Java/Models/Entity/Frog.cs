using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Frog : JavaEntityModel
    {
        public Frog() : base("Frog")
        {
            AddVersion("frog", "1.19.2")
                .WithTextureSize(48, 48)
                .AddElement("head", element => {
                    element.Part = "head";
                    element.Translate = new Vector3(0f, -4f, -3f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 5f, -4f),
                        Size = new Vector3(7f, 0f, 9f),
                        UV = new Vector2(23f, 13f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 3f, -4f),
                        Size = new Vector3(7f, 3f, 9f),
                        UV = new Vector2(0f, 13f),
                    });
                })
                .AddElement("eyes", element => {
                    element.Part = "eyes";
                    element.Translate = new Vector3(-0.5f, -4f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0.5f, 6f, -3f),
                        Size = new Vector3(3f, 2f, 3f),
                        UV = new Vector2(0f, 0f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 6f, -3f),
                        Size = new Vector3(3f, 2f, 3f),
                        UV = new Vector2(0f, 5f),
                    });
                })
                .AddElement("tongue", element => {
                    element.Part = "tongue";
                    element.Translate = new Vector3(0f, -3.1f, -5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-2f, 3.1f, -2.1f),
                        Size = new Vector3(4f, 0f, 7f),
                        UV = new Vector2(17f, 13f),
                    });
                })
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -2f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 1f, -4f),
                        Size = new Vector3(7f, 3f, 9f),
                        UV = new Vector2(3f, 1f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 3f, -4f),
                        Size = new Vector3(7f, 0f, 9f),
                        UV = new Vector2(23f, 22f),
                    });
                })
                .AddElement("croaking_body", element => {
                    element.Part = "croaking_body";
                    element.Translate = new Vector3(0f, -3f, 1f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-3.5f, 1.1f, -3.9f),
                        Size = new Vector3(7f, 2f, 3f),
                        UV = new Vector2(26f, 5f),
                        SizeAdd = -0.1f,
                    });
                })
                .AddElement("left_arm", element => {
                    element.Part = "left_arm";
                    element.Translate = new Vector3(4f, -3f, 2.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5f, 0f, -3.5f),
                        Size = new Vector3(2f, 3f, 3f),
                        UV = new Vector2(0f, 32f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-8f, -0.01f, -7.5f),
                        Size = new Vector3(8f, 0f, 8f),
                        UV = new Vector2(18f, 40f),
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "right_arm";
                    element.Translate = new Vector3(-4f, -3f, 2.5f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(3f, 0f, -3.5f),
                        Size = new Vector3(2f, 3f, 3f),
                        UV = new Vector2(0f, 38f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(0f, -0.01f, -7.5f),
                        Size = new Vector3(8f, 0f, 8f),
                        UV = new Vector2(2f, 40f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "left_leg";
                    element.Translate = new Vector3(3.5f, -3f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-5.5f, 0f, 2f),
                        Size = new Vector3(3f, 3f, 4f),
                        UV = new Vector2(14f, 25f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-9.5f, -0.01f, 0f),
                        Size = new Vector3(8f, 0f, 8f),
                        UV = new Vector2(2f, 32f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "right_leg";
                    element.Translate = new Vector3(-3.5f, -3f, -4f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(2.5f, 0f, 2f),
                        Size = new Vector3(3f, 3f, 4f),
                        UV = new Vector2(0f, 25f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, -0.01f, 0f),
                        Size = new Vector3(8f, 0f, 8f),
                        UV = new Vector2(18f, 32f),
                    });
                });
        }
    }
}
