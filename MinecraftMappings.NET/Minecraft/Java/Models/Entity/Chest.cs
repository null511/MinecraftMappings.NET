using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Chest : JavaEntityModel
    {
        public Chest() : base("Chest")
        {
            AddVersion("chest", "1.0.0")
                .WithTextureSize(64, 64)
                .AddElement("base", element => {
                    element.Translate = new Vector3(-8f, 0f, -8f);
                    element.RotationAngleX = -180;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-7f, -10f, 9f),
                        Size = new Vector3(14f, 10f, 14f),
                        UV = new Vector2(0f, 19f),
                    });
                })
                .AddElement("lid", element => {
                    element.Translate = new Vector3(-8f, -9f, -7f);
                    element.RotationAngleX = -140;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-7f, 4f, 7f),
                        Size = new Vector3(14f, 5f, 14f),
                        UV = new Vector2(0f, 0f),
                    });
                })
                .AddElement("knob", element => {
                    element.Translate = new Vector3(-8f, -8f, -8f);
                    element.RotationAngleX = -180;
                    element.InvertAxisX = true;
                    element.InvertAxisY = true;

                    element.Boxes.Add(new EntityElementCube {
                        Position = new Vector3(-1f, 5f, 23f),
                        Size = new Vector3(2f, 4f, 1f),
                        UV = new Vector2(0f, 0f),
                    });
                });
        }
    }
}
