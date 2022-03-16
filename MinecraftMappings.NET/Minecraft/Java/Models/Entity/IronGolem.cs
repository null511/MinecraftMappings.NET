using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class IronGolem : JavaEntityModel
    {
        public IronGolem() : base("Iron Golem")
        {
            AddVersion("iron_golem", "1.0.0")
                .WithTextureSize(128, 128)
                .AddElement("body", element => {
                    element.Part = "body";
                    element.Translate = new Vector3(0f, -31f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-9f, 21f, -6f),
                        Size = new Vector3(18f, 12f, 11f),
                        UV = new Vector2(0f, 40f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4.5f, 16f, -3f),
                        Size = new Vector3(9f, 5f, 6f),
                        UV = new Vector2(0f, 70f),
                        SizeAdd = 0.5f,
                    });
                })
                .AddElement("head", element => {
                    element.Part = "";
                    element.Translate = new Vector3(0f, -31f, 2f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-4f, 33f, -7.5f),
                        Size = new Vector3(8f, 10f, 8f),
                        UV = new Vector2(0f, 0f),
                    });
                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 32f, -9.5f),
                        Size = new Vector3(2f, 4f, 2f),
                        UV = new Vector2(24f, 0f),
                    });
                })
                .AddElement("right_arm", element => {
                    element.Part = "";
                    element.Translate = new Vector3(0f, -31f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(9f, 3.5f, -3f),
                        Size = new Vector3(4f, 30f, 6f),
                        UV = new Vector2(60f, 21f),
                    });
                })
                .AddElement("left_arm", element => {
                    element.Part = "";
                    element.Translate = new Vector3(0f, -31f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-13f, 3.5f, -3f),
                        Size = new Vector3(4f, 30f, 6f),
                        UV = new Vector2(60f, 58f),
                    });
                })
                .AddElement("right_leg", element => {
                    element.Part = "";
                    element.Translate = new Vector3(-4f, -13f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(1.5f, 0f, -3f),
                        Size = new Vector3(6f, 16f, 5f),
                        UV = new Vector2(37f, 0f),
                    });
                })
                .AddElement("left_leg", element => {
                    element.Part = "";
                    element.Translate = new Vector3(5f, -13f, 0f);
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-7.5f, 0f, -3f),
                        Size = new Vector3(6f, 16f, 5f),
                        UV = new Vector2(60f, 0f),
                    });
                });
        }
    }
}
