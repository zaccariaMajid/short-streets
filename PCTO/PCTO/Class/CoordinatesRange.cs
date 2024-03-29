﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class CoordinatesRange
    {
        public CoordinatesRange()
        {
            _minCoordinates = new Coordinates() { Lat = -90.0M, Lng = -180.0M, Confidence = 10 };
            _maxCoordinates = new Coordinates() { Lat = 90.0M, Lng = 180.0M, Confidence = 10 };
        }

        public override string ToString() => $"{MinCoordinates.Lat}, {MinCoordinates.Lng}/ {MaxCoordinates.Lat}, {MaxCoordinates.Lng}";
        Coordinates _minCoordinates;
        public Coordinates MinCoordinates
        {
            get => _minCoordinates;
            set => _minCoordinates = ControlLogic(value, _maxCoordinates)[0];
        }

        Coordinates _maxCoordinates;
        public Coordinates MaxCoordinates
        {
            get => _maxCoordinates;
            set => _maxCoordinates = ControlLogic(_minCoordinates, value)[1];
        }
        public static IList<Coordinates> ControlLogic(Coordinates min, Coordinates max)
        {
            if (min.Lat > max.Lat)
                throw new ArgumentException("Min latitude must be lower than max latitude");
            if (min.Lng > max.Lng)
                throw new ArgumentException("Min longitude must be lower than max longitude");
            return new List<Coordinates>() { min, max };
        }
    }
    public static class CoordinatesRangeManager
    {
        public static bool IsInRange(CoordinatesRange range, Coordinates c)
        {
            if (c.Lat < range.MinCoordinates.Lat ||
                c.Lng < range.MinCoordinates.Lng ||
                c.Lat > range.MaxCoordinates.Lat ||
                c.Lng > range.MaxCoordinates.Lng)
                return false;
            else
                return true;
        }
    }
}
