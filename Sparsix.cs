using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
   // begin vary
   public enum Dimension { None = 0, Item = 1, Dim1 = 2, Dim2 = 3, Dim3 = 4, Dim4 = 5, Dim5 = 6, Dim6 = 7, Dim7 = 8, Dim8 = 9, Dim9 = 10 }
   public enum NoDimension { NoItem = 0, NoDim1 = 0, NoDim2 = 0, NoDim3 = 0, NoDim4 = 0, NoDim5 = 0, NoDim6 = 0, NoDim7 = 0, NoDim8 = 0, NoDim9 = 0, }
   public class Coords
   {
      public static int Dims = 10;
      public int[] CoordVec = new int[Dims];
      public int Item { get { return CoordVec[0]; } set { CoordVec[0] = value; } }
      public int Dim1 { get { return CoordVec[1]; } set { CoordVec[1] = value; } }
      public int Dim2 { get { return CoordVec[2]; } set { CoordVec[2] = value; } }
      public int Dim3 { get { return CoordVec[3]; } set { CoordVec[3] = value; } }
      public int Dim4 { get { return CoordVec[4]; } set { CoordVec[4] = value; } }
      public int Dim5 { get { return CoordVec[5]; } set { CoordVec[5] = value; } }
      public int Dim6 { get { return CoordVec[6]; } set { CoordVec[6] = value; } }
      public int Dim7 { get { return CoordVec[7]; } set { CoordVec[7] = value; } }
      public int Dim8 { get { return CoordVec[8]; } set { CoordVec[8] = value; } }
      public int Dim9 { get { return CoordVec[9]; } set { CoordVec[9] = value; } }
      public Coords() { }
      public Coords(int item, int type1, int type2, int type3, int type4, int type5, int type6, int type7, int type8, int type9) { Item = item; Dim1 = type1; Dim2 = type2; Dim3 = type3; Dim4 = type4; Dim5 = type5; Dim6 = type6; Dim7 = type7; Dim8 = type8; Dim9 = type9; }
      public Coords(Coords coords) { Item = coords.Item; Dim1 = coords.Dim1; Dim2 = coords.Dim2; Dim3 = coords.Dim3; Dim4 = coords.Dim4; Dim5 = coords.Dim5; Dim6 = coords.Dim6; Dim7 = coords.Dim7; Dim8 = coords.Dim8; Dim9 = coords.Dim9; }
      public override string ToString() => $"[{Item,-3}, {(Type1)Dim1,-10}, {(Type2)Dim2,-12}, {(Type3)Dim3,-13}, {(Type4)Dim4,-10}, {(Type5)Dim5,-7}, {(Cat6)Dim6,-10}, {(Cat7)Dim7,-16}, {(Cat7)Dim8,-16}, {(Cat9)Dim9,-12}]";
      public string ToStringDimInterp() => $"[{(Dimension)Item}, {(Dimension)Dim1}, {(Dimension)Dim2}, {(Dimension)Dim3}, {(Dimension)Dim4}, {(Dimension)Dim5}, {(Dimension)Dim6}, {(Dimension)Dim7}, {(Dimension)Dim8}, {(Dimension)Dim9}]";
      public string ToStringUninterp() => $"[{Item}, {Dim1}, {Dim2}, {Dim3}, {Dim4}, {Dim5}, {Dim6}, {Dim7}, {Dim8}, {Dim9}]";
      public bool IsEqualTo(Coords c) => Equals(this, c);
      public static bool Equals(Coords c1, Coords c2)
      {
         if (c1 == null && c2 == null) return true;
         if (c1 == null || c2 == null) return false;
         for (var i = 0; i < Dims; i++)
            if (c1.CoordVec[i] != c2.CoordVec[i])
               return false;
         return true;
      }
      public static Coords BuildCoords1(int itemId, int type1Id, int type2Id, int type3Id, int type4Id, int type5Id, int type6Id, int type7Id, int type8Id, int type9Id) => new Coords(itemId, type1Id, type2Id, type3Id, type4Id, type5Id, type6Id, type7Id, type8Id, type9Id);
      public static Coords BuildCoords2(int itemId, int type1Id, int type2Id, int type4Id, int type5Id, int type6Id, int type7Id, int type8Id, int type9Id) => new Coords(itemId, type1Id, type2Id, (int)Type3.Inst3_1, type4Id, type5Id, type6Id, type7Id, type8Id, type9Id);
      public static Coords BuildCoords3(int itemId, int type1Id, int type4Id, int type5Id, int type6Id, int type7Id, int type8Id, int type9Id) => BuildCoords2(itemId, type1Id, (int)Type2.Inst2_2, type4Id, type5Id, type6Id, type7Id, type8Id, type9Id);
      public static Coords BuildCoords4(int type1Id, int type4Id, int type7Id, int type8Id, int type9Id) => BuildCoords2((int)NoDimension.NoItem, type1Id, (int)NoDimension.NoDim2, type4Id, (int)NoDimension.NoDim5, (int)NoDimension.NoDim6, type7Id, type8Id, type9Id);
      public static Coords BuildCoords5(int type4Id, int type7Id, int type8Id, int type9Id) => new Coords((int)NoDimension.NoItem, (int)NoDimension.NoDim1, (int)NoDimension.NoDim2, (int)NoDimension.NoDim3, type4Id, (int)NoDimension.NoDim5, (int)NoDimension.NoDim6, type7Id, type8Id, type9Id);
      public static Coords GetVector1() => new Coords( (int)Dimension.Item, (int)NoDimension.NoDim1, (int)Dimension.Dim2, (int)NoDimension.NoDim3, (int)Dimension.Dim4, (int)Dimension.Dim5, (int)Dimension.Dim6, (int)Dimension.Dim7, (int)NoDimension.NoDim8, (int)NoDimension.NoDim9);
      public static Coords GetVector2() => new Coords( (int)Dimension.Item, (int)Dimension.Dim1, (int)Dimension.Dim2, (int)Dimension.Dim3, (int)Dimension.Dim4, (int)Dimension.Dim5, (int)Dimension.Dim6, (int)Dimension.Dim7, (int)Dimension.Dim8, (int)Dimension.Dim9);
      public static Coords GetVector3() => new Coords( (int)NoDimension.NoItem, (int)NoDimension.NoDim1, (int)NoDimension.NoDim2, (int)Type3.Inst3_2, (int)Type4.NoApply, (int)NoDimension.NoDim5, (int)NoDimension.NoDim7, (int)NoDimension.NoDim6, (int)NoDimension.NoDim8, (int)NoDimension.NoDim9);
      public static Coords GetVector4() => new Coords( (int)Dimension.Item, (int)Dimension.Dim1, (int)Dimension.Dim2, (int)Dimension.Dim3, (int)Dimension.Dim4, (int)Dimension.Dim5, (int)Dimension.Dim6, (int)Dimension.Dim7, (int)NoDimension.NoDim8, (int)NoDimension.NoDim9);
      public static Coords GetVector5() => new Coords( (int)NoDimension.NoItem, (int)NoDimension.NoDim1, (int)NoDimension.NoDim2, (int)Type3.Inst3_3, (int)Type4.NoApply, (int)NoDimension.NoDim5, (int)NoDimension.NoDim6, (int)NoDimension.NoDim7, (int)NoDimension.NoDim8, (int)NoDimension.NoDim9);
      public static Coords GetVector6(Type5 type5) => new Coords( (int)NoDimension.NoItem, (int)Type1.NoApply, (int)Type2.Inst2_6, (int)Type3.NoApply, (int)Type4.NoApply, (int)type5, (int)NoDimension.NoDim6, (int)NoDimension.NoDim7, (int)NoDimension.NoDim8, (int)NoDimension.NoDim9);
      public static Coords GetVector7() => new Coords( (int)Dimension.Item, (int)Dimension.Dim1, (int)NoDimension.NoDim2, (int)NoDimension.NoDim3, (int)Dimension.Dim4, (int)NoDimension.NoDim5, (int)Dimension.Dim6, (int)NoDimension.NoDim7, (int)Dimension.Dim8, (int)Dimension.Dim9);
   }
   public enum Type1 { NoApply = -1, Inst1_1 = 1, Inst1_2 = 2, Inst1_3 = 4, Inst1_4 = 5, Inst1_5 = 6, Inst1_6 = 7, Inst1_7 = 9 }
   public enum Type2 { NoApply = -1, Inst2_1 = 1, Inst2_2 = 2, Inst2_3 = 3, Inst2_4 = 5, Inst2_5 = 8, Inst2_6 = 9 }
   public enum Type3 { NoApply = -1, Inst3_1 = 1, Inst3_2 = 2, Inst3_3 = 3 }
   public enum Type4 { NoApply = -1, Inst4_1 = 1, Inst4_2 = 2 }
   public enum Type5 { NoApply = -1, Inst5_1 = 1, Inst5_2 = 2 }
   // end vary

   public class DimManager
   {
      public Dictionary<Dimension, DimSet> DimSets { get; set; } = new Dictionary<Dimension, DimSet>();
      public DimManager(bool reset = false)
      {
         for (var i = 1; i < Coords.Dims + 1; i++)
            DimSets[(Dimension)i] = new DimSet();
         if (reset) Reset();
      }
      public Coords Size()
      {
         var size = new Coords();
         for (var i = 0; i < Coords.Dims; i++)
            size.CoordVec[i] = DimSets[(Dimension)(i + 1)].Cardinality;
         return size;
      }
      public void Add(Coords pos)
      {
         for (var i = 0; i < Coords.Dims; i++)
            DimSets[(Dimension)(i + 1)].Add(pos.CoordVec[i]);
      }
      public void Reset()
      {
         for (var i = 0; i < Coords.Dims; i++)
            DimSets[(Dimension)(i + 1)].Add(0);
      }
      public HashSet<int> GetDimSet(Dimension dimension) => DimSets[dimension].Set;
      public DimSet this[Dimension dimension] => DimSets[dimension];
      public override string ToString()
      {
         var sb = new StringBuilder();
         foreach (var dimSetPair in DimSets)
            sb.Append($"{dimSetPair.Key}: {dimSetPair.Value}, ");
         return sb.ToString();
      }
   }
   public class MatrixMethods
   {
      public static DimManager CopyDimensions(Matrix matrix)
      {
         var dimMgr = new DimManager();
         for (var i = 1; i < Coords.Dims + 1; i++)
            dimMgr.DimSets[(Dimension)i].Set.UnionWith(matrix.GetDimSet((Dimension)i));
         return dimMgr;
      }
      public static DimManager CopyDimensions(Matrix matrix, Coords dimensions)
      {
         var dimMgr = new DimManager();
         for (var i = 0; i < Coords.Dims; i++)
         {
            if (dimensions.CoordVec[i] == 0)
               dimMgr.DimSets[(Dimension)(i + 1)].Add(0);
            else
               dimMgr.DimSets[(Dimension)(i + 1)].Set.UnionWith(matrix.GetDimSet((Dimension)(i + 1)));
         }
         return dimMgr;
      }
      public static Matrix Project(Matrix m1, Dimension normal, string name = null)
      {
         var res = new Matrix($"(Proj: {m1.Name}, norm: {normal})", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;

            var p2 = new Coords();
            for (var i = 0; i < Coords.Dims; i++)
               p2.CoordVec[i] = (int)normal == (i + 1) ? 0 : p1.CoordVec[i];

            res.Add(p2, e1);
         }
         return res;
      }
      public static Matrix Project(Matrix m1, Coords normal, string name = null)
      {
         var res = new Matrix($"(Proj: {m1.Name}, norm: {normal.ToStringDimInterp()})", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;

            var p2 = new Coords();
            for (var i = 0; i < Coords.Dims; i++)
               p2.CoordVec[i] = normal.CoordVec[i] != 0 ? 0 : p1.CoordVec[i];

            res.Add(p2, e1);
         }
         return res;
      }
      public static Matrix FilterIncl(Matrix m1, DimManager range, string name = null)
      {
         var res = new Matrix($"(Filt: {m1.Name}, range: {range}, filter type: Inclusive)", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;
            var remove = false;
            for (var i = 0; i < Coords.Dims; i++)
               if (range[(Dimension)(i + 1)].Set.Contains(p1.CoordVec[i]) == false)
                  remove = true;
            if (!remove)
               res.Add(p1, e1);
         }
         return res;
      }
      public static Matrix FilterExcl(Matrix m1, DimManager range, string name = null)
      {
         var res = new Matrix($"(Filt: {m1.Name}, range: {range}, filter type: Exclusive)", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;
            var remove = false;
            for (var i = 0; i < Coords.Dims; i++)
               if (range[(Dimension)(i + 1)].Set.Contains(p1.CoordVec[i]))
                  remove = true;
            if (!remove)
               res.Add(p1, e1);
         }
         return res;
      }
      public static Matrix Filter(Matrix m1, Coords filter, FilterType filterType = FilterType.Inclusive, string name = null)
      {
         var res = new Matrix($"(Filt: {m1.Name}, filter: {filter.ToStringUninterp()}, filter type: {filterType})", name);
         var incl = filterType == FilterType.Inclusive;
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;
            var remove = false;
            var pos = new Coords();
            for (var i = 0; i < Coords.Dims; i++)
            {
               pos.CoordVec[i] = incl
                  ? (filter.CoordVec[i] == 0 ? p1.CoordVec[i] : filter.CoordVec[i] == p1.CoordVec[i] ? p1.CoordVec[i] : -1)
                  : (filter.CoordVec[i] == 0 ? -1 : filter.CoordVec[i] != p1.CoordVec[i] ? p1.CoordVec[i] : -1);

               if (pos.CoordVec[i] == -1)
                  remove = true;
            }
            if (!remove)
               res.Add(pos, e1);
         }
         return res;
      }
      public static Matrix Filter(Matrix m1, Dimension dim, int value, FilterType filterType = FilterType.Inclusive, string name = null)
      {
         var filter = new Coords { CoordVec = { [((int)dim) - 1] = value } };
         return Filter(m1, filter, filterType, name);
      }
      public static Matrix MultByExtr(Matrix m1, Matrix m2, Coords extr, string name = null)
      {
         var res = new Matrix($"({m1.Name} x {m2.Name}, extr: {extr.ToStringDimInterp()})", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;
            // check if element exists in m2
            var e2 = m2[p1];
            if (e2 == null)
            {
               // element does not exist, extrude it!
               var p2 = new Coords();
               for (var i = 0; i < Coords.Dims; i++)
                  p2.CoordVec[i] = extr.CoordVec[i] != 0 ? 0 : p1.CoordVec[i];
               e2 = m2[p2];
            }
            res.Add(p1, e1 * e2); // Hadamard product
         }
         return res;
      }
      public static Matrix MultByExtr(Matrix m1, decimal value, string name = null)
      {
         var res = new Matrix($"({m1.Name} x {value})", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;
            res.Add(p1, e1 * value);
         }
         return res;
      }
      public static Matrix Translate(Matrix m1, Coords trans, string name = null)
      {
         var res = new Matrix($"({m1.Name}, trans: {trans})", name);
         foreach (var posElPair in m1.Elements)
         {
            var p1 = posElPair.Key;
            var e1 = posElPair.Value;
            // translate
            var p2 = new Coords();
            for (var i = 0; i < Coords.Dims; i++)
               p2.CoordVec[i] = trans.CoordVec[i] != 0 ? trans.CoordVec[i] : p1.CoordVec[i];
            res.Add(p2, e1);
         }
         return res;
      }
   } // class CostMatrixMethods

   // simulated ids
   public enum Cat6 { Inst6_1 = 1, Inst6_2 = 2 }
   public enum Cat7 { Inst7_1 = 1, Inst7_2 = 2, Inst7_3 = 3, Inst7_4 = 4 }
   public enum Cat9 { Inst9_1 = 1, Inst9_2 = 2, Inst9_3 = 3, Inst9_4 = 5 }
   public enum Cat10 { Inst10_1 = 1, Inst10_2 = 2, Inst10_3 = 3, Inst10_4 = 4, Inst10_5 = 5 }

   public enum FilterType
   {
      Inclusive = 1,
      Exclusive = 2,
      Complement = 3
   }

   // dimension set ---------------------------------------------------------------------------
   public class DimSet
   {
      public HashSet<int> Set { get; set; } = new HashSet<int>();
      public DimSet() { }
      public DimSet(int e) { Add(e); }
      public DimSet(params int[] els)
      {
         foreach (var e in els)
            Add(e);
      }
      public int Cardinality => Set.Count;
      public int Min => Set.Min(x => x);
      public int Max => Set.Max(x => x);
      public bool Has(int e) => Set.Contains(e);
      public bool Add(int e) => Set.Add(e); // true if set element doesn't exist, false if the set element is already present
      public void Add(params int[] els)
      {
         foreach (var e in els)
            Add(e);
      }
      public bool Remove(int e) => Set.Remove(e);
      public void Remove(params int[] els)
      {
         foreach (var e in els)
            Remove(e);
      }
      public override string ToString() => $"({string.Join(",", Set.ToArray())})";
   }

   // element of the matrix
   // it keeps track of all the ids of the values added to this element
   // this means that we can track all the item ids that originated this value
   public class Element
   {
      public decimal Value { get; set; }
      public HashSet<int> Ids { get; set; } = new HashSet<int>(); // the ids that originated this value
      public Element() { }
      public Element(decimal value) { Value = value; }
      public Element(decimal value, int id)
      {
         Value = value;
         if (id != 0)
            Ids.Add(id);
      }
      public Element(decimal value, IEnumerable<int> ids)
      {
         Value = value;
         Ids.UnionWith(ids);
      }
      public Element(Element e)
      {
         Value = e.Value;
         Ids.UnionWith(e.Ids);
      }
      public void Set(decimal value)
      {
         Value = value;
         Ids = new HashSet<int>(); // reset list of ids
      }
      public void Add(decimal value, int id = 0)
      {
         Value += value;
         if (id != 0)
            Ids.Add(id);
      }
      public void Add(Element e)
      {
         Value += e.Value;
         Ids.UnionWith(e.Ids);
      }
      public override string ToString()
      {
         return $"{Value:#0.00} ({Ids.Count}: {string.Join(",", Ids.ToArray())})";
      }
      public static Element operator +(Element e1, Element e2)
      {
         if (e1 == null) return e2;
         if (e2 == null) return e1;
         var el = new Element { Value = e1.Value + e2.Value };
         el.Ids.UnionWith(e1.Ids);
         el.Ids.UnionWith(e2.Ids);
         return el;
      }
      public static Element operator -(Element e1, Element e2)
      {
         if (e2 == null) return e1;
         var e3 = new Element { Value = -e2.Value, Ids = e2.Ids };
         return e1 + e3;
      }
      public static Element operator *(Element e1, Element e2)
      {
         if (e1 == null || e2 == null)
            return null;
         // we keep always the list of ids of operand e1.
         // we ignore always the list of ids of operand e2.
         return new Element { Value = e1.Value * e2.Value, Ids = e1.Ids };
      }
      public static Element operator *(Element e, decimal f)
      {
         if (e == null)
            return null;
         // we keep always the list of ids of operand e1
         return new Element { Value = e.Value * f, Ids = e.Ids };
      }
      public static Element operator *(decimal f, Element e)
      {
         return e * f;
      }
   }

   public class Matrix
   {
      public string Name { get; set; }
      public string Desc { get; set; }
      public Dictionary<Coords, Element> Elements { get; set; } = new Dictionary<Coords, Element>();
      public DimManager DimManager = new DimManager();
      public Matrix(string desc, string name = null)
      {
         Desc = desc;
         Name = name ?? desc;
      }
      public bool Contains(Coords pos) => Elements.Any(x => x.Key.IsEqualTo(pos));
      public Coords Size() => DimManager.Size();
      public int Count() => Elements.Count;
      public bool Empty() => Count() == 0;
      public HashSet<int> GetDimSet(Dimension dimension) => DimManager.GetDimSet(dimension);
      public Dictionary<Dimension, DimSet> GetDimSets() => DimManager.DimSets;
      public bool HasSameSizeAs(Matrix matrix) => Size().Equals(matrix.Size());
      public decimal GetValueOrDefault(Coords pos)
      {
         var e = this[pos];
         if (e == null) return 0;
         return e.Value;
      }
      public void Add(Coords pos, decimal value)
      {
         if (value == 0) return;
         var el = this[pos];
         if (el == null)
         {
            DimManager.Add(pos);
            this[pos] = new Element(value, pos.Item);
         }
         else
            el.Add(value);
      }
      public void Add(Coords pos, Element e)
      {
         if (e == null) return;
         if (e.Value == 0) return;
         var el = this[pos];
         if (el == null)
         {
            DimManager.Add(pos);
            this[pos] = new Element(e.Value, e.Ids);
         }
         else
            el.Add(e);
      }
      public void Set(Coords pos, decimal e)
      {
         var el = this[pos];
         if (el == null)
         {
            DimManager.Add(pos);
            this[pos] = new Element(e, pos.Item);
         }
         else
            el.Value = e;
      }
      public void Set(Coords pos, Element e)
      {
         if (e == null) return;
         if (this[pos] == null)
         {
            DimManager.Add(pos);
            this[pos] = new Element(e);
         }
         else
            this[pos] = e;
      }
      public Matrix Remove(Matrix m, string name = null)
      {
         var res = new Matrix($"({Name}.Remove({m.Name})", name);
         foreach (var pos in Elements.Select(value => value.Key))
         {
            if (m.Contains(pos))
               continue;
            res.DimManager.Add(pos);
            res[pos] = this[pos];
         }
         return res;
      }
      public void Dump()
      {
         Console.WriteLine("{0}, count: {1}", Name, Elements.Count);
         if (!Name.Equals(Desc)) Console.WriteLine(Desc);
         foreach (var pair in Elements)
            Console.WriteLine("{0} = {1}", pair.Key, pair.Value);
         Console.WriteLine();
      }
      public Element this[Coords pos]
      {
         get { return Elements.FirstOrDefault(x => x.Key.IsEqualTo(pos)).Value; }
         set { Elements[pos] = value; }
      }
      public static Matrix operator +(Matrix m1, Matrix m2)
      {
         var res = new Matrix($"({m1.Name} + {m2.Name})");
         foreach (var pos in m1.Elements.Select(value => value.Key).Union(m2.Elements.Select(value => value.Key)).Select(x => new Coords(x)))
         {
            res.DimManager.Add(pos);
            res[pos] = m1[pos] + m2[pos];
         }
         return res;
      }
      public static Matrix operator -(Matrix m1, Matrix m2)
      {
         var res = new Matrix($"({m1.Name} - {m2.Name})");
         foreach (var pos in m1.Elements.Select(value => value.Key).Union(m2.Elements.Select(value => value.Key)).Select(x => new Coords(x)))
         {
            res.DimManager.Add(pos);
            res[pos] = m1[pos] - m2[pos];
         }
         return res;
      }
      public static Matrix operator *(Matrix m1, Matrix m2)
      {
         var res = new Matrix($"({m1.Name} * {m2.Name})");
         foreach (var pos in m1.Elements.Select(value => value.Key).Where(x => m2.Contains(new Coords(x))).Select(x => new Coords(x)))
         {
            res.DimManager.Add(pos);
            res[pos] = m1[pos] * m2[pos];
         }
         return res;
      }
      public DimManager CopyDimensions(Coords dimensions = null)
      {
         return dimensions == null ?
            MatrixMethods.CopyDimensions(this) :
            MatrixMethods.CopyDimensions(this, dimensions);
      }
      public Matrix Project(Dimension normal, string name = null) => MatrixMethods.Project(this, normal, name);
      public Matrix Project(Coords normal, string name = null) => MatrixMethods.Project(this, normal, name);
      public Matrix Filter(DimManager range, FilterType filterType = FilterType.Inclusive, string name = null)
      {
         return filterType == FilterType.Inclusive ?
            MatrixMethods.FilterIncl(this, range, name) :
            filterType == FilterType.Exclusive ?
               MatrixMethods.FilterExcl(this, range, name) :
               Remove(MatrixMethods.FilterIncl(this, range), name);
      }
      public Matrix Filter(Coords filter, FilterType filterType = FilterType.Inclusive, string name = null)
      {
         return filterType == FilterType.Complement ?
            Remove(MatrixMethods.Filter(this, filter), name) :
            MatrixMethods.Filter(this, filter, filterType, name);
      }
      public Matrix Filter(Dimension dim, int value, FilterType filterType = FilterType.Inclusive, string name = null)
      {
         return filterType == FilterType.Complement ?
            Remove(MatrixMethods.Filter(this, dim, value), name) :
            MatrixMethods.Filter(this, dim, value, filterType, name);
      }
      public Matrix MultByExtr(Matrix m2, Coords extrusion, string name = null) => MatrixMethods.MultByExtr(this, m2, extrusion, name);
      public Matrix MultByExtr(decimal value, string name = null) => MatrixMethods.MultByExtr(this, value, name);
      public Matrix Translate(Coords translation, string name = null) => MatrixMethods.Translate(this, translation, name);
   }

   public class Composite
   {
      public int Id { get; set; } = 0;
      public List<Composite> Children { get; } = new List<Composite>();
      public void Add(Composite child) { Children.Add(child); }
      public void Remove(Composite child)
      {
         if (Children.Contains(child))
            Children.Remove(child);
      }
      public virtual void Dump() { Children.ForEach(child => child.Dump()); }
      public virtual void CalcIndComp(CalcComps comps) { Children.ForEach(child => child.CalcIndComp(comps)); }
   }
   public class Container1 : Composite
   {
      public bool Flag1 { get; set; }
      public decimal Value1 { get; set; }
      public decimal Value2 { get; set; }
      public override void CalcIndComp(CalcComps comps)
      {
         comps.Value1 = Value1;
         comps.Flag1 = Flag1;
         comps.Value2 = Value2;
         base.CalcIndComp(comps);
      }
      public override void Dump()
      {
         Console.WriteLine($"- Cont1: {Id}");
         Console.WriteLine($"  - Flag1: {Flag1}");
         base.Dump();
      }
   }
   public class Container2 : Composite
   {
      public int Data1 { get; set; }
      public override void CalcIndComp(CalcComps comps)
      {
         comps.Value3 = Id;
         comps.Value4 = Data1;
         comps.Value5 = Type5.Inst5_2;
         comps.Value6 = Type5.Inst5_2;
         comps.Value7 = Type5.Inst5_1;
         comps.Value8 = Type5.Inst5_1;
         base.CalcIndComp(comps);
      }
      public override void Dump()
      {
         Console.WriteLine($"   - Cont2: {(Cat6)Id}");
         Console.WriteLine($"     - D1: {Data1}");
         base.Dump();
      }
   }
   public class Container3 : Composite
   {
      public int Value4 { get; set; }
      public Type2 Type2 { get; set; }
      public Type5 Value5 { get; set; }
      public Type5 Value6 { get; set; }
      public Type5 Value7 { get; set; }
      public Type5 Value8 { get; set; }
      public int Attr1 { get; set; }
      public int Attr2 { get; set; }
      public int Attr3 { get; set; }
      public int Attr4 { get; set; }
      public decimal Attr5 { get; set; }
      public decimal Attr6 { get; set; }

      // vary
      public override void CalcIndComp(CalcComps comps)
      {
         comps.Items[Id] = this;
         Value4 = comps.Value4;
         Value5 = comps.Value5;
         Value6 = comps.Value6;
         Value7 = comps.Value7;
         Value8 = comps.Value8;
         var flag2 = true;
         var type5Inst1 = flag2 ? Value5 : Value6;
         var type5Inst2 = flag2 ? Value7 : Value8;
         var amount1 = C1();
         var amount2 = C2();
         var amount3 = C3();
         var type4 = (Attr2 == (int)Cat7.Inst7_3 && Attr3 == (int)Cat9.Inst9_4) ? Type4.Inst4_2 : Type4.Inst4_1;
         if (Attr6 > 0)
         {
            var amount4 = amount1 * Attr6; amount1 -= amount4;
            comps.Am1.Add(Coords.BuildCoords3(Id, (int)Type1.Inst1_1, (int)type4, (int)type5Inst1, comps.Value3, Attr1, Attr2, Attr3), amount4);
            var amount5 = amount2 * Attr6; amount2 -= amount5;
            comps.Am2.Add(Coords.BuildCoords3(Id, (int)Type1.Inst1_2, (int)Type4.Inst4_1, (int)type5Inst1, comps.Value3, Attr1, Attr2, Attr3), amount5);
            if (comps.Flag1)
            {
               var amount6 = amount3 * Attr6; amount3 -= amount6;
               comps.Am3.Add(Coords.BuildCoords3(Id, (int)Type1.Inst1_5, (int)type4, (int)type5Inst1, comps.Value3, Attr1, Attr2, Attr3), amount6);
            }
         }
         var type5 = (Type2 == Type2.Inst2_5) || (Type2 == Type2.Inst2_4) || (Type2 == Type2.Inst2_3) ? type5Inst1 : type5Inst2;
         comps.Am1.Add(Coords.BuildCoords2(Id, (int)Type1.Inst1_1, (int)Type2, (int)type4, (int)type5, comps.Value3, Attr1, Attr2, Attr3), amount1);
         comps.Am2.Add(Coords.BuildCoords2(Id, (int)Type1.Inst1_2, (int)Type2, (int)Type4.Inst4_1, (int)type5, comps.Value3, Attr1, Attr2, Attr3), amount2);
         comps.Am3.Add(Coords.BuildCoords2(Id, (int)Type1.Inst1_5, (int)Type2, (int)type4, (int)type5, comps.Value3, Attr1, Attr2, Attr3), amount3);
         var amount7 = C4();
         if (amount7 > 0) comps.Am6.Add(Coords.BuildCoords4((int)Type1.Inst1_7, 0, 0, Attr2, Attr3), amount7);
         comps.Ratios1.Set(Coords.BuildCoords4((int)Type1.Inst1_1, 0, 0, Attr2, Attr3), Read1(Attr2, Attr3));
         comps.Ratios2.Set(Coords.BuildCoords4((int)Type1.Inst1_2, 0, 0, Attr2, Attr3), Read2(Attr2, Attr3));
         comps.Ratios3.Set(Coords.BuildCoords4((int)Type1.Inst1_5, 0, 0, Attr2, Attr3), Read3(Attr2, Attr3));
         comps.Ratios4.Set(Coords.BuildCoords4((int)Type1.Inst1_3, 0, 0, Attr2, Attr3), Read1(Attr2, Attr3));
         comps.Ratios5.Set(Coords.BuildCoords4((int)Type1.Inst1_4, 0, 0, Attr2, Attr3), Read5(Attr2, Attr3));
         if (Attr2 == (int)Cat7.Inst7_4) comps.Ratios6.Set(Coords.BuildCoords5(0, 0, Attr2, Attr3), Read6(Attr2, Attr3));
      }
      // end vary

      public virtual decimal C1() => Attr5 * 2 * Value4;
      public virtual decimal C2() => Attr5 * 3 * Value4;
      public virtual decimal C3() => Attr5 * 0.5m * Value4;
      public virtual decimal C4() => Id == 100 ? 1.2m * Value4 : 0;
      public virtual decimal Read1(int type8Id, int type9Id) => 4 * type8Id * type9Id;
      public virtual decimal Read2(int type8Id, int type9Id) => 3 * type8Id * type9Id;
      public virtual decimal Read3(int type8Id, int type9Id) => 2 * type8Id * type9Id;
      public virtual decimal Read5(int type8Id, int type9Id) => 1 * type8Id * type9Id;
      public virtual decimal Read6(int type8Id, int type9Id) => 0.1m * type8Id * type9Id;
      public override void Dump()
      {
         Console.WriteLine($"      - Cont3: {Id}");
         Console.WriteLine($"          - D9 : {(Cat9)Attr3}");
         Console.WriteLine($"          - D7 : {(Cat7)Attr1}");
         Console.WriteLine($"          - D8 : {(Cat7)Attr2}");
         Console.WriteLine($"          - A4: {(Cat10)Attr4}");
         Console.WriteLine($"          - A5: {Attr5}");
         Console.WriteLine($"          - A6: {Attr6}");
         Console.WriteLine($"          - T2: {(Type2)Type2}");
      }
   }
   // end of composite

   public class CalcComps
   {
      public bool Flag1 { get; set; }
      public decimal Value1 { get; set; }
      public decimal Value2 { get; set; }
      public Dictionary<int, Container3> Items { get; set; } = new Dictionary<int, Container3>();
      public int Value3 { get; set; }
      public int Value4 { get; set; }
      public Type5 Value5 { get; set; }
      public Type5 Value6 { get; set; }
      public Type5 Value7 { get; set; }
      public Type5 Value8 { get; set; }
      public Matrix Am1 { get; set; } = new Matrix("Am1 [u1]");
      public Matrix Am2 { get; set; } = new Matrix("Am2 [$]");
      public Matrix Am3 { get; set; } = new Matrix("Am3 [u3]");
      public Matrix Am4 { get; set; } = new Matrix("Am4 [u1]");
      public Matrix Am5 { get; set; } = new Matrix("Am5 [u5]");
      public Matrix Am6 { get; set; } = new Matrix("Am6 [uX]");
      public Matrix Am1Pr { get; set; } = new Matrix("Am1Pr [u1]");
      public Matrix Am4Ex { get; set; } = new Matrix("Am4Ex [u1]");
      public Matrix Am5Ex { get; set; } = new Matrix("Am5Ex [u5]");
      public Matrix Ratios1 { get; set; } = new Matrix("R1 [$/u1]");
      public Matrix Ratios2 { get; set; } = new Matrix("R2 [$/$]");
      public Matrix Ratios3 { get; set; } = new Matrix("R3 [$/u3]");
      public Matrix Ratios4 { get; set; } = new Matrix("R4 [$/u1]");
      public Matrix Ratios5 { get; set; } = new Matrix("R5 [$/u5]");
      public Matrix Ratios6 { get; set; } = new Matrix("R6 [u/u]");
      public Matrix Am1Cost { get; set; }
      public Matrix Am2Cost { get; set; }
      public Matrix Am3Cost { get; set; }
      public Matrix Am4Cost { get; set; }
      public Matrix Am5Cost { get; set; }
      public Matrix Cost0 { get; set; }
      public Matrix Cost1 { get; set; }
      public Matrix Cost2 { get; set; }
      public Matrix Cost3 { get; set; }
      public Matrix Cost4 { get; set; }
      public Matrix Cost5 { get; set; }
      public Matrix CostZ { get; set; }

      // vary
      public void CalcDepComps()
      {
         Am1Pr = Am1.Project(Coords.GetVector1(), "am1Pr [u1]");
         foreach (var posElPair in Am1Pr.Elements)
         {
            var am1Pos = posElPair.Key;
            var am1Val = posElPair.Value.Value;
            var valX = Calc1(am1Val, am1Pos.Dim8, am1Pos.Dim9);
            Am6.Add(Coords.BuildCoords4((int)Type1.Inst1_7, 0, 0, am1Pos.Dim8, am1Pos.Dim9), valX);
            Am4.Add(Coords.BuildCoords4((int)Type1.Inst1_3, 0, 0, am1Pos.Dim8, am1Pos.Dim9), Calc2(am1Val, valX, am1Pos.Dim8, am1Pos.Dim9));
            Am5.Add(Coords.BuildCoords4((int)Type1.Inst1_4, 0, 0, am1Pos.Dim8, am1Pos.Dim9), Calc3(am1Val, valX, am1Pos.Dim8, am1Pos.Dim9));
         }
         foreach (var posElPair in Am1.Elements)
         {
            var am1Pos = posElPair.Key;
            var am1Val = posElPair.Value.Value;
            var am1Tot = Am1Pr[Coords.BuildCoords4((int)Type1.Inst1_1, 0, 0, am1Pos.Dim8, am1Pos.Dim9)].Value;
            var ratio = am1Val / am1Tot;
            var type2 = Flag1 ?  am1Pos.Dim2 : (int)Items[am1Pos.Item].Type2;
            var am4Pr = Am4.GetValueOrDefault(Coords.BuildCoords4((int)Type1.Inst1_3, 0, 0, am1Pos.Dim8, am1Pos.Dim9));
            Am4Ex.Add(Coords.BuildCoords2(am1Pos.Item, (int)Type1.Inst1_3, am1Pos.Dim2, am1Pos.Dim4, am1Pos.Dim5, am1Pos.Dim6, am1Pos.Dim7, am1Pos.Dim8, am1Pos.Dim9), am4Pr * ratio);
            var am5Pr = Am5.GetValueOrDefault(Coords.BuildCoords4((int)Type1.Inst1_4, 0, 0, am1Pos.Dim8, am1Pos.Dim9));
            Am5Ex.Add(Coords.BuildCoords2(am1Pos.Item, (int)Type1.Inst1_4, type2, am1Pos.Dim4, am1Pos.Dim5, am1Pos.Dim6, am1Pos.Dim7, am1Pos.Dim8, am1Pos.Dim9), am5Pr * ratio);
         }
      }
      // end vary

      private decimal Calc1(decimal u1, int type8, int type9) => type9 == (int)Cat9.Inst9_4 ? 0 : 0.1m * u1 * type8 * type9;
      private decimal Calc2(decimal u1, decimal amX, int type8, int type9) => 0.1m * u1 * type8 * type9 * amX;
      private decimal Calc3(decimal u1, decimal amX, int type8, int type9) => 0.2m * u1 * type8 * type9 * amX;

      public void CalcCostComps()
      {
         var ratioExtr = Coords.GetVector1();
         Am1Cost = Am1.MultByExtr(Ratios1, ratioExtr, "Am1Cost [$]");
         Am2Cost = Am2.MultByExtr(Ratios2, ratioExtr, "Am2Cost [$]");
         Am3Cost = Am3.MultByExtr(Ratios3, ratioExtr, "Am3Cost [$]");
         Am4Cost = Am4Ex.MultByExtr(Ratios4, ratioExtr, "Am4Cost [$]");
         Am5Cost = Am5Ex.MultByExtr(Ratios5, ratioExtr, "Am5Cost [$]");
         Cost0 = Am1Cost + Am4Cost + Am2Cost + Am5Cost + Am3Cost;
         Cost0.Name = "Cost0 [$]";
         Cost1 = Cost0.Filter(Dimension.Dim4, (int)Type4.Inst4_2, FilterType.Inclusive, "Cost1 {N} [$]");
         Cost2 = Cost0.Filter(Dimension.Dim4, (int)Type4.Inst4_1, FilterType.Inclusive, "Cost2 {T} [$]");
         Cost3 = Cost2.MultByExtr(Value1);
         Cost3 = Cost3.Translate(Coords.GetVector3(), "Cost3 [$]");
         var cost4 = Cost2 + Cost3;
         Cost4 = cost4.Filter(Dimension.Dim8, (int)Cat7.Inst7_4, FilterType.Inclusive, "Cost4 [$]");
         if (Cost4.Empty()) {
            Cost5 = new Matrix("Cost5 [$]");
         } else {
            Cost5 = Cost4.MultByExtr(Ratios6, Coords.GetVector4());
            Cost5 = Cost5.Translate(Coords.GetVector5(), "Cost5 [$]");
         }
         CostZ = Cost1 + cost4 + Cost5;
         CostZ.Name = "CostZ [$]";
      }
      public void CalcCostRedist1() { CalcCostRedist1_1(); }
       public void CalcCostRedist1_1()
       {
          if (Value2 <= 0) return;
          CostZ.Add(Coords.GetVector6(Type5.Inst5_2), Value2);
           CostZ.Add(Coords.GetVector6(Type5.Inst5_1), -Value2);
       }
   }

   public class Calculation
   {
      private Container1 _cont1;
      private CalcComps _comps;
      public void Calculate()
      {
         LoadContainer1();
         _cont1.CalcIndComp(_comps);
         _comps.CalcDepComps();
         _comps.CalcCostComps();
         _comps.CalcCostRedist1();
         PrintIndComps();
         PrintDepComps();
         PrintCostComps();
         PrintCost2Comps();
      }
      private void LoadContainer1()
      {
         _comps = new CalcComps();
         _cont1 = new Container1
         {
            Id = 1,
            Value1 = 0.25m,
            Flag1 = false,
            Value2 = 100m,
            Children =
            {
               new Container2
               {
                  Id = (int)Cat6.Inst6_1,
                  Data1 = 1,
                  Children =
                  {
                     new Container3
                     {
                        Id = 100,
                        Attr3 = (int)Cat9.Inst9_1,
                        Attr1 = (int)Cat7.Inst7_1,
                        Attr2 = (int)Cat7.Inst7_1,
                        Attr4 = (int)Cat10.Inst10_1,
                        Attr5 = 5,
                        Attr6 = 0,
                        Type2 = Type2.Inst2_1
                     },
                     new Container3
                     {
                        Id = 101,
                        Attr3 = (int)Cat9.Inst9_1,
                        Attr1 = (int)Cat7.Inst7_1,
                        Attr2 = (int)Cat7.Inst7_1,
                        Attr4 = (int)Cat10.Inst10_2,
                        Attr5 = 3,
                        Attr6 = 0,
                        Type2 = Type2.Inst2_1
                     },
                     new Container3
                     {
                        Id = 102,
                        Attr3 = (int)Cat9.Inst9_1,
                        Attr1 = (int)Cat7.Inst7_1,
                        Attr2 = (int)Cat7.Inst7_4,
                        Attr4 = (int)Cat10.Inst10_3,
                        Attr5 = 1,
                        Attr6 = 0.1m,
                        Type2 = Type2.Inst2_3
                     },
                     new Container3
                     {
                        Id = 103,
                        Attr3 = (int)Cat9.Inst9_3,
                        Attr1 = (int)Cat7.Inst7_1,
                        Attr2 = (int)Cat7.Inst7_1,
                        Attr4 = (int)Cat10.Inst10_5,
                        Attr5 = 10,
                        Attr6 = 0.5m,
                        Type2 = Type2.Inst2_1
                     },
                     new Container3
                     {
                        Id = 104,
                        Attr3 = (int)Cat9.Inst9_1,
                        Attr1 = (int)Cat7.Inst7_1,
                        Attr2 = (int)Cat7.Inst7_1,
                        Attr4 = (int)Cat10.Inst10_4,
                        Attr5 = 2,
                        Attr6 = 0,
                        Type2 = Type2.Inst2_5
                     },
                  }
               },
               new Container2
               {
                  Id = (int)Cat6.Inst6_2,
                  Data1 = 1,
                  Children =
                  {
                     new Container3
                     {
                        Id = 200,
                        Attr3 = (int)Cat9.Inst9_1,
                        Attr1 = (int)Cat7.Inst7_2,
                        Attr2 = (int)Cat7.Inst7_2,
                        Attr4 = (int)Cat10.Inst10_1,
                        Attr5 = 3,
                        Attr6 = 0.1m,
                        Type2 = Type2.Inst2_1
                     },
                     new Container3
                     {
                        Id = 201,
                        Attr3 = (int)Cat9.Inst9_1,
                        Attr1 = (int)Cat7.Inst7_2,
                        Attr2 = (int)Cat7.Inst7_2,
                        Attr4 = (int)Cat10.Inst10_2,
                        Attr5 = 2,
                        Attr6 = 0.5m,
                        Type2 = Type2.Inst2_1
                     },
                     new Container3
                     {
                        Id = 202,
                        Attr3 = (int)Cat9.Inst9_3,
                        Attr1 = (int)Cat7.Inst7_1,
                        Attr2 = (int)Cat7.Inst7_1,
                        Attr4 = (int)Cat10.Inst10_5,
                        Attr5 = 12,
                        Attr6 = 0,
                        Type2 = Type2.Inst2_3
                     },
                     new Container3
                     {
                        Id = 203,
                        Attr3 = (int)Cat9.Inst9_4,
                        Attr1 = (int)Cat7.Inst7_3,
                        Attr2 = (int)Cat7.Inst7_3,
                        Attr4 = (int)Cat10.Inst10_5,
                        Attr5 = 1,
                        Attr6 = 0.2m,
                        Type2 = Type2.Inst2_5
                     },
                     new Container3
                     {
                        Id = 204,
                        Attr3 = (int)Cat9.Inst9_2,
                        Attr1 = (int)Cat7.Inst7_3,
                        Attr2 = (int)Cat7.Inst7_3,
                        Attr4 = (int)Cat10.Inst10_4,
                        Attr5 = 3,
                        Attr6 = 0.1m,
                        Type2 = Type2.Inst2_1
                     },
                  }
               }
            }
         };
         _cont1.Dump();
      }

      private void PrintIndComps()
      {
         _comps.Am1.Dump();
         _comps.Am2.Dump();
         _comps.Am3.Dump();
         _comps.Ratios1.Dump();
         _comps.Ratios2.Dump();
         _comps.Ratios3.Dump();
         _comps.Ratios5.Dump();
         _comps.Ratios4.Dump();
         _comps.Ratios6.Dump();
      }

      private void PrintDepComps()
      {
         var am1NoPr = _comps.Am1;
         var am1PrO = am1NoPr.Project(Dimension.Item);
         var am1PrA = am1PrO.Project(Dimension.Dim2);
         var am1PrT = am1PrA.Project(Dimension.Dim4);
         var am1PrD = am1PrT.Project(Dimension.Dim5);
         var am1PrS = am1PrD.Project(Dimension.Dim6);
         var am1PrG = am1PrS.Project(Dimension.Dim7);
         am1NoPr.Dump();
         am1PrO.Dump();
         am1PrA.Dump();
         am1PrT.Dump();
         am1PrD.Dump();
         am1PrS.Dump();
         am1PrG.Dump();
         _comps.Am1Pr.Dump();
         _comps.Am6.Dump();
         _comps.Am4.Dump();
         _comps.Am5.Dump();
         _comps.Am4Ex.Dump();
         _comps.Am5Ex.Dump();
         _comps.Am4Ex.
            Project(Dimension.Item).
            Project(Dimension.Dim2).
            Project(Dimension.Dim4).
            Project(Dimension.Dim5).
            Project(Dimension.Dim6).
            Project(Dimension.Dim7).
            Dump();
      }

      private void PrintCostComps()
      {
         _comps.Am1Cost.Dump();
         _comps.Am2Cost.Dump();
         _comps.Am3Cost.Dump();
         _comps.Am4Cost.Dump();
         _comps.Am5Cost.Dump();
         _comps.Cost0.Dump();
         _comps.Cost1.Dump();
         _comps.Cost2.Dump();
         _comps.Cost3.Dump();
         _comps.Cost4.Dump();
         _comps.Cost5.Dump();
         _comps.CostZ.Dump();
      }

      private void PrintCost2Comps()
      {
         var costA = _comps.CostZ.Project(Coords.GetVector7(), "Rep1");
         var costB = costA.Project(Dimension.Dim2).Project(Dimension.Dim7, "Rep2");
         var costC = costB.Project(Dimension.Dim3, "Rep3");
         var costD = costC.Project(Coords.GetVector2(), "Total");
         costA.Dump();
         costB.Dump();
         costC.Dump();
         costD.Dump();
         var costS = _comps.CostZ.CopyDimensions();
         costS.DimSets[Dimension.Dim2] = new DimSet((int)Type2.Inst2_2, (int)Type2.Inst2_5, (int)Type2.Inst2_3);
         var costT = _comps.CostZ.Filter(costS, FilterType.Inclusive, "CostT [$]");
         costT.Dump();
         costT.
             Project(Dimension.Item).
             Project(Dimension.Dim1).
             Project(Dimension.Dim4).
             Project(Dimension.Dim6).
             Project(Dimension.Dim7).
             Project(Dimension.Dim8).
             Project(Dimension.Dim9).
             Dump();
      }
   }

   // main program *************************************************************
   class Program
   {
      static void Main(string[] args)
      {
         if (args.Length == 1)
         {
            if (args[0] == "ops")
               BasicExampleOfMatrixOperations();
            else if (args[0] == "filter")
               BasicExampleOfMatrixFilter();
            else
               Console.WriteLine("ERROR: argument not supported!");
         }
         else
            new Calculation().Calculate();
      }
      private static void BasicExampleOfMatrixOperations()
      {
         var m1 = new Matrix("Mat1");
         var m2 = new Matrix("Mat2");
         var m3 = new Matrix("Mat3");
         m1.Add(Coords.BuildCoords2(10, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 5.0m);
         m1.Add(Coords.BuildCoords2(10, (int)Type1.Inst1_2, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 8.0m);
         m1.Add(Coords.BuildCoords2(11, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 2.0m);
         m1.Add(Coords.BuildCoords2(12, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 3.0m);
         m1.Add(Coords.BuildCoords2(13, (int)Type1.Inst1_1, (int)Type2.Inst2_5, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 1.0m);
         m1.Add(Coords.BuildCoords2(14, (int)Type1.Inst1_3, (int)Type2.Inst2_2, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 2, 1, 1, 1), 6.0m);
         m1.Add(Coords.BuildCoords2(20, (int)Type1.Inst1_1, (int)Type2.Inst2_3, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 2, 2, 3), 9.0m);
         m1.Add(Coords.BuildCoords2(30, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 3, 4, 4, 5), 4.0m);
         m2.Add(Coords.BuildCoords2(10, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 3.0m);
         m2.Add(Coords.BuildCoords2(20, (int)Type1.Inst1_1, (int)Type2.Inst2_3, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 2, 2, 3), 7.0m);
         m2.Add(Coords.BuildCoords2(30, (int)Type1.Inst1_1, (int)Type2.Inst2_2, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 3, 4, 4, 5), 2.0m);
         m3.Add(Coords.BuildCoords2(0, 0, 0, 0, 0, 0, 1, 1, 1), 3.0m);
         m3.Add(Coords.BuildCoords2(0, 0, 0, 0, 0, 0, 2, 2, 3), 7.0m);
         m3.Add(Coords.BuildCoords2(0, 0, 0, 0, 0, 0, 4, 4, 5), 2.0m);
         var r1 = m1 + m2;
         var r2 = m1 - m2;
         var r3 = m1 * m2;
         var r4 = m1 * m3;
         var r5 = m1.MultByExtr(m3, Coords.BuildCoords2(0, 0, 0, 0, 0, 0, 1, 1, 1));
         var p1 = m1.Project(Dimension.Item);
         var p2 = p1.Project(Dimension.Dim1);
         var p3 = p2.Project(Dimension.Dim2);
         var p4 = p3.Project(Dimension.Dim6);
         m1.Dump(); m2.Dump(); m3.Dump();
         r1.Dump(); r2.Dump(); r3.Dump();
         r4.Dump(); r5.Dump();
         p1.Dump(); p2.Dump(); p3.Dump(); p4.Dump();
      }

      private static void BasicExampleOfMatrixFilter()
      {
         var m = new Matrix("DummyMatrix");
         m.Add(Coords.BuildCoords2(10, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 5.0m);
         m.Add(Coords.BuildCoords2(10, (int)Type1.Inst1_2, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 8.0m);
         m.Add(Coords.BuildCoords2(11, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 2.0m);
         m.Add(Coords.BuildCoords2(12, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 3.0m);
         m.Add(Coords.BuildCoords2(13, (int)Type1.Inst1_1, (int)Type2.Inst2_5, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 1, 1, 1), 1.0m);
         m.Add(Coords.BuildCoords2(14, (int)Type1.Inst1_3, (int)Type2.Inst2_2, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 2, 1, 1, 1), 6.0m);
         m.Add(Coords.BuildCoords2(20, (int)Type1.Inst1_1, (int)Type2.Inst2_3, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 1, 2, 2, 3), 9.0m);
         m.Add(Coords.BuildCoords2(30, (int)Type1.Inst1_1, (int)Type2.Inst2_1, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 3, 4, 4, (int)Cat9.Inst9_4), 4.0m);
         m.Add(Coords.BuildCoords2(30, (int)Type1.Inst1_1, (int)Type2.Inst2_2, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 3, 4, 4, (int)Cat9.Inst9_4), 4.0m);
         m.Add(Coords.BuildCoords2(30, (int)Type1.Inst1_3, (int)Type2.Inst2_3, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 3, 4, 4, (int)Cat9.Inst9_4), 4.0m);

         Console.WriteLine("SOURCE MATRIX ===========================================\n");
         m.Dump();

         Console.WriteLine("EMPTY RANGE ********************************************************************************************************************\n");
         var f0 = new DimManager();
         m.Filter(f0, FilterType.Inclusive, "01 - empty range, inclusive filter").Dump();
         m.Filter(f0, FilterType.Exclusive, "02 - empty range, exclusive filter").Dump();
         m.Filter(f0, FilterType.Complement, "03 - empty range, complement filter").Dump();

         Console.WriteLine("ALL DIMENSIONS + RANGE ==================\n");
         var f1 = m.CopyDimensions();
         f1.DimSets[Dimension.Dim9] = new DimSet((int)Cat9.Inst9_4);
         m.Filter(f1, FilterType.Inclusive, "04 - all dims and some range, inclusive filter").Dump();
         m.Filter(f1, FilterType.Exclusive, "05 - all dims and some range, exclusive filter").Dump();
         m.Filter(f1, FilterType.Complement, "06 - all dims and some range, complement filter").Dump();

         Console.WriteLine("JUST RANGE ==============================\n");
         var f2 = new DimManager { DimSets = { [Dimension.Dim9] = new DimSet((int)Cat9.Inst9_4) } };
         m.Filter(f2, FilterType.Inclusive, "07 - just some range, inclusive filter").Dump();
         m.Filter(f2, FilterType.Exclusive, "08 - just some range, exclusive filter").Dump();
         m.Filter(f2, FilterType.Complement, "09 - just some range, complement filter").Dump();

         Console.WriteLine("EMPTY COORDS *******************************************************************************************************************\n");
         var f3 = new Coords();
         m.Filter(f3, FilterType.Inclusive, "10 - empty coords, inclusive filter").Dump();
         m.Filter(f3, FilterType.Exclusive, "11 - empty coords, exclusive filter").Dump();
         m.Filter(f3, FilterType.Complement, "12 - empty coords, complement filter").Dump();

         Console.WriteLine("ALL DIMENSIONS + COORDS =================\n");
         var f4 = Coords.BuildCoords1(0, 0, 0, 0, 0, 0, 0, 0, 0, (int)Cat9.Inst9_4);
         m.Filter(f4, FilterType.Inclusive, "13 - all dims and some coords, inclusive filter").Dump();
         m.Filter(f4, FilterType.Exclusive, "14 - all dims and some coords, exclusive filter").Dump();
         m.Filter(f4, FilterType.Complement, "15 - all dims and some coords, complement filter").Dump();

         Console.WriteLine("AM1 + COORDS ===========================\n");
         var f5 = Coords.BuildCoords4((int)Type1.Inst1_1, (int)Type4.Inst4_1, (int)Cat7.Inst7_2, (int)Cat7.Inst7_2, (int)Cat9.Inst9_4);
         m.Filter(f5, FilterType.Inclusive, "16 - am1 and some coords, inclusive filter").Dump();
         m.Filter(f5, FilterType.Exclusive, "17 - am1 and some coords, exclusive filter").Dump();
         m.Filter(f5, FilterType.Complement, "18 - am1 and some coords, complement filter").Dump();

         Console.WriteLine("SPECIFIC COORDS =========================================\n");
         var f6 = Coords.BuildCoords2(30, (int)Type1.Inst1_3, (int)Type2.Inst2_3, (int)Type4.Inst4_1, (int)Type5.Inst5_1, 3, 4, 4, (int)Cat9.Inst9_4);
         m.Filter(f6, FilterType.Inclusive, "19 - specific coords existing, inclusive filter").Dump();
         m.Filter(f6, FilterType.Exclusive, "20 - specific coords existing, exclusive filter").Dump();
         m.Filter(f6, FilterType.Complement, "21 - specific coords existing, complement filter").Dump();

         Console.WriteLine("SPECIFIC COORDS 2 =======================================\n");
         var f7 = Coords.BuildCoords4((int)Type1.Inst1_6, (int)Type4.Inst4_1, 0, 0, 0);
         m.Filter(f7, FilterType.Inclusive, "22 - specific coords not existing, inclusive filter").Dump();
         m.Filter(f7, FilterType.Exclusive, "23 - specific coords not existing, exclusive filter").Dump();
         m.Filter(f7, FilterType.Complement, "24 - specific coords not existing, complement filter").Dump();

         Console.WriteLine("EMPTY DIM **********************************************************************************************************************\n");
         m.Filter(Dimension.None, 0, FilterType.Inclusive, "25 - empty dim, inclusive filter").Dump();
         m.Filter(Dimension.None, 0, FilterType.Exclusive, "26 - empty dim, exclusive filter").Dump();
         m.Filter(Dimension.None, 0, FilterType.Complement, "27 - empty dim, complement filter").Dump();

         Console.WriteLine("DIM =====================================\n");
         m.Filter(Dimension.Dim9, (int)Cat9.Inst9_4, FilterType.Inclusive, "28 - some dim, inclusive filter").Dump();
         m.Filter(Dimension.Dim9, (int)Cat9.Inst9_4, FilterType.Exclusive, "29 - some dim, exclusive filter").Dump();
         m.Filter(Dimension.Dim9, (int)Cat9.Inst9_4, FilterType.Complement, "30 - some dim, complement filter").Dump();
      }
   }
}
