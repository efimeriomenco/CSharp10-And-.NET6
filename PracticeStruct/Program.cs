
SumStruct dv1 = new(3, 5);
SumStruct dv2 = new(-2, 7);
SumStruct dv3 = dv1 + dv2;

WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{ dv3.Y})");