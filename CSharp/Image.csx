#! "dotnetcoreapp2.0"
#r "nuget:NetStandard.Library,2.0"
#r "nuget:SixLabors.ImageSharp,1.0.0-beta0001"

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.Primitives;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

using (var image = Image.Load("Images/big-photo.jpg"))
{
    image.Mutate(ctx => ctx.Resize(image.Width / 2, image.Height / 2));
    image.Save("Images/small-photo.jpg");
}