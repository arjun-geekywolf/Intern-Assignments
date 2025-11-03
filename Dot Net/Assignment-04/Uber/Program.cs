using Uber;

UberSystem uber = new UberSystem("Driver1","Passenger1",12);
uber.RideDetails();

UberSystem uber1 = new UberSystem("Driver2", "Passenger2", 10);
uber1.RideDetails();

UberSystem.SurgeMultiplier(2);

UberSystem uber2 = new UberSystem("Driver3", "Passenger3", 10);
uber2.RideDetails();

UberSystem.RideSummary();

