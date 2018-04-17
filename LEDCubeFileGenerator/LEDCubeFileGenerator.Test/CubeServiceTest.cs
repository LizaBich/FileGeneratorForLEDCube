using System.Collections.Generic;
using LEDCubeFileGenerator.Common.Interfaces;
using LEDCubeFileGenerator.Common.Models;
using LEDCubeFileGenerator.Common.Services;
using NUnit.Framework;

namespace LEDCubeFileGenerator.Test
{
    [TestFixture]
    public class CubeServiceTest
    {
        private ICubeService _cubeService;

        [SetUp]
        public void Initialize()
        {
            this._cubeService = new CubeService(2);
        }

        [Test]
        public void CubeService_AddPoint_HowItWorks()
        {
            this._cubeService.AddPoint(0,0);

            IList<PointModel> pattern = new List<PointModel>
            {
                new PointModel(2)
                {
                    XY = 0,
                    Z = 0
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }

        [Test]
        public void CubeService_AddRow_HowItWorksIfX()
        {
            this._cubeService.AddRow(true, 1, 0);

            IList<PointModel> pattern = new List<PointModel>()
            {
                new PointModel(2)
                {
                    XY = 0,
                    Z = 1
                },
                new PointModel(2)
                {
                    XY = 1,
                    Z = 1
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }

        [Test]
        public void CubeService_AddRow_HowItWorksIfY()
        {
            this._cubeService.AddRow(false, 1, 0);

            IList<PointModel> pattern = new List<PointModel>()
            {
                new PointModel(2)
                {
                    XY = 0,
                    Z = 1
                },
                new PointModel(2)
                {
                    XY = 2,
                    Z = 1
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }

        [Test]
        public void CubeService_AddHorizontalLayer_HowItWorks()
        {
            this._cubeService.AddHorizontalLayer(0);

            IList<PointModel> pattern = new List<PointModel>
            {
                new PointModel(2)
                {
                    XY = 0,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 1,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 2,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 3,
                    Z = 0
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }

        [Test]
        public void CubeService_AddVerticalLayer_HowItWorksIfX()
        {
            this._cubeService.AddVerticalLayer(true, 2);

            IList<PointModel> pattern = new List<PointModel>
            {
                new PointModel(2)
                {
                    XY = 2,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 3,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 2,
                    Z = 1
                },
                new PointModel(2)
                {
                    XY = 3,
                    Z = 1
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }

        [Test]
        public void CubeService_AddVerticalLayer_HowItWorksIfY()
        {
            this._cubeService.AddVerticalLayer(false, 1);

            IList<PointModel> pattern = new List<PointModel>
            {
                new PointModel(2)
                {
                    XY = 1,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 3,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 1,
                    Z = 1
                },
                new PointModel(2)
                {
                    XY = 3,
                    Z = 1
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }

        [Test]
        public void CubeService_AddColumn_HowItWorks()
        {
            this._cubeService.AddColumn(3);

            IList<PointModel> pattern = new List<PointModel>
            {
                new PointModel(2)
                {
                    XY = 3,
                    Z = 0
                },
                new PointModel(2)
                {
                    XY = 3,
                    Z = 1
                }
            };

            CollectionAssert.AreEqual(pattern, this._cubeService.Cube.Points);
        }
    }
}
