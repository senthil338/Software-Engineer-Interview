using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Problems
{
    public class ParkingLot
    {
        private Level[] levels;
    private const int NUM_LEVELS = 5;
	
	public ParkingLot() {
		levels = new Level[NUM_LEVELS];
		for (int i = 0; i < NUM_LEVELS; i++) {
			levels[i] = new Level(i, 30);
		}
	}
	
	/* Park the vehicle in a spot (or multiple spots). Return false if failed. */
	public bool parkVehicle(Vehicle vehicle) {
		for (int i = 0; i < levels.Length; i++) {
			if (levels[i].parkVehicle(vehicle)) {
				return true;
			}
		}
		return false;
	}
	
	public void print() {
		for (int i = 0; i < levels.Length; i++) {
			Console.WriteLine("Level" + i + ": ");
			levels[i].print();
			Console.WriteLine("");
		}
        Console.WriteLine("");
	}
    }

    public class Level {
        private int floor;
        private ParkingSpot[] spots;
        private int availableSpots = 0; // number of free spots
        private const int SPOTS_PER_ROW = 10;

        public Level(int flr, int numberSpots)
        {
            floor = flr;
            spots = new ParkingSpot[numberSpots];

            int largeSpots = numberSpots / 4;
            int bikeSpots = numberSpots / 4;
            int compactSpots = numberSpots - largeSpots - bikeSpots;
            for (int i = 0; i < numberSpots; i++)
            {
                VehicleSize sz = VehicleSize.Motorcycle;
                if (i < largeSpots)
                {
                    sz = VehicleSize.Large;
                }
                else if (i < largeSpots + compactSpots)
                {
                    sz = VehicleSize.Compact;
                }
                int row = i / SPOTS_PER_ROW;
                spots[i] = new ParkingSpot(this, row, i, sz);
            }
            availableSpots = numberSpots;
        }

        public int AvailableSpots() { return availableSpots; }

        /* Find a place to park this vehicle. Return false if failed. */
        public bool parkVehicle(Vehicle vehicle)
        {
            if (AvailableSpots() < vehicle.getSpotsNeeded()) {
                return false;
            }
            int spotNumber = findAvailableSpots(vehicle);
            if (spotNumber < 0)
            {
                return false;
            }

            return parkStartingAtSpot(spotNumber, vehicle);
        }

        /* Park a vehicle starting at the spot spotNumber, and
        * continuing until vehicle.spotsNeeded. */
        private bool parkStartingAtSpot(int num, Vehicle v)
        {
            
            v.clearSpots();
            //bool success = true;
            for (int i = num; i < num + v.getSpotsNeeded(); i++)
            {
                if (!spots[i].park(v))
                {
                    return false;
                }
               
            }
            availableSpots = availableSpots - v.getSpotsNeeded();
            return true;

        }

        /* Find a spot to park this vehicle. Return index of spot, or -1
         * on failure. */
        private int findAvailableSpots(Vehicle vehicle)
        {
            int spotFound = 0;
            int spotNeeded = vehicle.getSpotsNeeded();
            int lastRow = -1;

            for (int j = 0; j < spots.Length; j++) {
                ParkingSpot spot = spots[j];
                if (lastRow != spot.getRow())
                {
                    spotFound = 0;
                    lastRow = spot.getRow();
                }
                if (spot.canFitVehicle(vehicle))
                {
                    spotFound++;
                }
                else {
                    spotFound = 0;
                }
                if (spotFound == spotNeeded) {
                    return j - (spotNeeded - 1);
                }
            }

            return -1;
            
        }

        public void print() {
		int lastRow = -1;
		for (int i = 0; i < spots.Length; i++) {
			ParkingSpot spot = spots[i];
            if (spot != null)
            {
                if (spot.getRow() != lastRow)
                {
                    Console.WriteLine("  ");
                    lastRow = spot.getRow();
                }
                spot.print();
            }
		}
	}
        /* When a car was removed from the spot, increment
        * availableSpots */
        public void spotFreed() { availableSpots++; }
    }
    public enum VehicleSize  { Motorcycle, Compact, Large  }
    
    public abstract class Vehicle
    {
        List<ParkingSpot> parkingSpots = new List<ParkingSpot>();
        protected String licensePlate;
        protected int spotsNeeded;
        protected VehicleSize size;
        public int getSpotsNeeded()
        {
            return spotsNeeded;
        }

        public VehicleSize getSize()
        {
            return size;
        }
        public void parkInSpot(ParkingSpot s)
        {
            parkingSpots.Add(s);
        }
        public void clearSpots() {
            for (int i = 0; i < parkingSpots.Count; i++) {
                parkingSpots[i].removeVehicle();
            }
            parkingSpots.Clear();
        }

        public abstract bool canFitinSpot(ParkingSpot spot);
        public abstract void print();

    }

    public class Car : Vehicle {
        public Car()
        {
            spotsNeeded = 1;
            size = VehicleSize.Compact;
        }

        /* Checks if the spot is a Compact or a Large. */
        public override bool canFitinSpot(ParkingSpot spot)
        {
            return spot.getSize() == VehicleSize.Large || spot.getSize() == VehicleSize.Compact;
        }

        public override void print()
        {
            Console.WriteLine("C");
        }
    }
    public class Bus : Vehicle {
        public Bus()
        {
            spotsNeeded = 5;
            size = VehicleSize.Large;
        }

        /* Checks if the spot is a Large. Doesn't check
         num of spots */
        public override bool canFitinSpot(ParkingSpot spot)
        {
            return spot.getSize() == VehicleSize.Large;
        }

        public override void print()
        {
            Console.WriteLine("B");
        }
    }
    public class Motorcycle : Vehicle {
       
        public Motorcycle()
        {
            spotsNeeded = 1;
            size = VehicleSize.Motorcycle;
        }

        public override bool canFitinSpot(ParkingSpot spot)
        {
            return spot.getSize() ==  VehicleSize.Large || spot.getSize() == VehicleSize.Compact ||spot.getSize() == VehicleSize.Motorcycle;
        }

        public override void print()
        {
           Console.WriteLine("M");
        }
    }
    public class ParkingSpot
    {
        private Vehicle vehicle;
        private VehicleSize spotSize;
        private int row;
        private int spotNumber;
        private Level level;

        public ParkingSpot(Level lvl, int r, int n,
                          VehicleSize s)
        {
            level = lvl;
            row = r;
            spotNumber = n;
            spotSize = s;
        }

        public bool isAvailable()
        {
            return vehicle == null;
        }

        /* Check if the spot is big enough and is available */
        public bool canFitVehicle(Vehicle vehicle)
        {
            return isAvailable() && vehicle.canFitinSpot(this);
        }

        /* Park vehicle in this spot. */
        public bool park(Vehicle v)
        {
            if (!canFitVehicle(v))
            {
                return false;
            }
            
               v.parkInSpot(this);
               return true;
        }

        public int getRow()
        {
            return row;
        }
        public int getSpotNumber()
        {
            return spotNumber;
        }

        /* Remove vehicle from spot, and notify
          level that a new spot is available */
        public void removeVehicle()
        {
            level.spotFreed();
            vehicle = null;
        }
        public VehicleSize getSize()
        {
            return spotSize;
        }

        public void print() {
		if (vehicle == null) {
			if (spotSize == VehicleSize.Compact) {
				Console.WriteLine("c");
			} else if (spotSize == VehicleSize.Large) {
				Console.WriteLine("l");
			} else if (spotSize == VehicleSize.Motorcycle) {
                Console.WriteLine("m");
			}
		} else {
			vehicle.print();
		}
	}
    }
}
