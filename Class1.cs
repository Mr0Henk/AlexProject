using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Multicad;
using Multicad.Runtime;
using Multicad.DatabaseServices;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Mc3D;
using Multicad.AplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlexProject
{
    public class Class1
    {
        [CommandMethod("Alex", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Form_Detal()
        {
            Window frm = new Window();
            frm.Show();
        }

        [CommandMethod("detail3d", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Sample3d()
        {
            //получаем данные из класса
            double cube = AlexDetal.cube3d;
            double circleRad = AlexDetal.circleRad3d;
            double midle = cube / 2;

            //подготавливаем форму для черчения
            var activeSheet = McDocumentsManager.GetActiveSheet();
            Mc3dSolid Detail3d = new Mc3dSolid();

            bool addingSolidResult = McObjectManager.Add2Document(Detail3d.DbEntity, activeSheet);
            Detail3d.DbEntity.AddToCurrentDocument();

            PlanarSketch sketchDetail1 = Detail3d.AddPlanarSketch();

            // прописываем элементы

            DbPolyline po1 = new DbPolyline()
            {
                Polyline = new Polyline3d(new List<Point3d>()
                {
                    new Point3d(0,0,0),//1

                    new Point3d(0,cube,0),//2
                    new Point3d(cube,cube,0),//3
                    new Point3d(cube,0,0),//4

                    new Point3d(0,0,0)//1
                })
            };
            //добовляем в документ
            po1.DbEntity.AddToCurrentDocument();

            //присваиваем ID
            sketchDetail1.AddObject(po1.ID);

            //создаём профаил для выдавливания
            SketchProfile profile1 = sketchDetail1.CreateProfile();
            profile1.AutoProcessExternalContours();//автоопределение замкнутого контура

            ExtrudeFeature EF1 = Detail3d.AddExtrudeFeature(
                profile1.ID,//id элементов для выдавливания
                cube,// растояние выдавливания
                0,//угол выдавливания
                FeatureExtentDirection.Positive // направление выдавливания
                );
            EF1.Operation = PartFeatureOperation.Join; //выдавливаем как сложение
            McObjectManager.UpdateAll();

            //отверстие

            //*************центральная резьба скетч
            PlanarSketch sketchDetail2 = Detail3d.AddPlanarSketch();
            DbCircle circle2 = new DbCircle() // 1 окружность
            {
                Center = new Point3d(midle, midle, cube),
                Radius = circleRad
            };

            //получаем конечную грань первого выдавливания
            //чтобы строить выдавливание дальше
            List<McObjectId> endFacesIds2 = EF1.GetEndFEV(EntityGeomType.kSurfaceEntities);
            //эскиз будет построен на второй(новой) плоскости
            sketchDetail2.PlanarEntityID = endFacesIds2[0];
            sketchDetail2.DbEntity.Visibility = 0; //делаем эскиз невидимым
            //добавляем окружность в документ
            circle2.DbEntity.AddToCurrentDocument();
            //присваиваем id будущим фигурам
            sketchDetail2.AddObject(circle2.ID);


            //создаём профаил для выдавливания
            SketchProfile profile2 = sketchDetail2.CreateProfile();
            profile2.AutoProcessExternalContours();//автоопределение замкнутого контура
            //создаём новое выдавливание

            ExtrudeFeature EF2 = new ExtrudeFeature();
            EF2 = Detail3d.AddExtrudeFeature(
                profile2.ID,//id элементов для выдавливания
                cube,// растояние выдавливания
                0,//угол выдавливания
                FeatureExtentDirection.Negative // направление выдавливания
                );
            EF2.Operation = PartFeatureOperation.Cut; //выдавливаем как сложение

            //скрываем элементы
            sketchDetail1.DbEntity.Visibility = 0;
            sketchDetail2.DbEntity.Visibility = 0;
            profile1.DbEntity.Visibility = 0;
            profile2.DbEntity.Visibility = 0;
            McObjectManager.UpdateAll(); //всё сохраняем

        }

        [CommandMethod("detail2d", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Sample2d()
        {
            //получаем данные из класса
            int rad = AlexDetal.rad2d;
            double diag = AlexDetal.diag2d;
            double half = diag / 2;
            //подготавливаем форму для черчения
            var activeSheet = McDocumentsManager.GetActiveSheet();
            Mc3dSolid Detail2d = new Mc3dSolid();

            bool addingSolidResult = McObjectManager.Add2Document(Detail2d.DbEntity, activeSheet);
            Detail2d.DbEntity.AddToCurrentDocument();

            PlanarSketch sketchDetail = Detail2d.AddPlanarSketch();

            //добавление элементов
            DbPolyline po = new DbPolyline()
            {
                Polyline = new Polyline3d(new List<Point3d>()
                {
                    new Point3d(-half,0,0), //1

                    new Point3d(0,half,0), //2
                    new Point3d(half,0,0), //3
                    new Point3d(0,-half,0), //4

                    new Point3d(-half,0,0) //1
                
                })
            };


            DbCircle circle = new DbCircle() // первая окружность
            {
                Center = new Point3d(0, 0, 0),
                Radius = rad
            };

            po.DbEntity.AddToCurrentDocument();
            circle.DbEntity.AddToCurrentDocument();

            //добавление объёмных объектов осуществляеться через ID
            sketchDetail.AddObject(po.ID);
            sketchDetail.AddObject(circle.ID);

            //создаём профаил для выдавливания
            SketchProfile profile = sketchDetail.CreateProfile();
            //profile.AutoProcessExternalContours();//автоопределение замкнутого контура
            McObjectManager.UpdateAll();
        }

        public static void My_detal3d()
        {
            McContext.ExecuteCommand("detail3d");
        }
        public static void My_detal2d()
        {
            McContext.ExecuteCommand("detail2d");
        }

    }
}
