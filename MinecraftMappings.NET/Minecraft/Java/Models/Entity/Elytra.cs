using MinecraftMappings.Internal.Models.Entity;
using SharpDX;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Elytra : JavaEntityModel
    {
        public Elytra() : base("Elytra")
        {
            AddVersion("elytra", "1.0.0")
                .WithTextureSize(64, 32)
                .AddElement("left_wing", element => {
                    element.RotationAngleX = 180f;
                    element.RotationAngleZ = 180f;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(-11f, 0f, -2f),
                        Size = new Vector3(10f, 20f, 4f),

                        UV_Up = UVMap(34f, 2f, 24f, 0f),
                        UV_Down = UVMap(44f, 0f, 34f, 2f),
                        UV_North = UVMap(24f, 2f, 34f, 22f),
                        UV_South = UVMap(36f, 2f, 46f, 22f),
                        UV_West = UVMap(34f, 2f, 36f, 22f),
                        UV_East = UVMap(22f, 2f, 24f, 22f),
                    });
                })
                .AddElement("right_wing", element => {
                    element.RotationAngleX = 180f;
                    element.RotationAngleZ = 180f;
                    element.MirrorTexU = true;

                    element.Cubes.Add(new EntityElementCube {
                        Position = new Vector3(1f, 0f, -2f),
                        Size = new Vector3(10f, 20f, 4f),

                        UV_Up = UVMap(24f, 2f, 34f, 0f),
                        UV_Down = UVMap(34f, 0f, 44f, 2f),
                        UV_North = UVMap(34f, 2f, 24f, 22f),
                        UV_South = UVMap(46f, 2f, 36f, 22f),
                        UV_West = UVMap(24f, 2f, 22f, 22f),
                        UV_East = UVMap(36f, 2f, 34f, 22f),
                    });
                });
        }
    }
}
