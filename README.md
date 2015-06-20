# apixu-csharp
Code library in C# for using Apixu.com Developer API

##### Get forecast weather data by a searching key value:
```
GetWeatherData(String key, RequestBlocks.GetBy getBy, String value, RequestBlocks.Days ForecastOfDays) 
```

##### Get weather data by Latitude and longitude:
```
GetWeatherDataByLatLong( String key, String latitude, String longitude, RequestBlocks.Days ForecastOfDays) 
```

##### Get weather data by IP Address:
```
GetWeatherDataByAutoIP(String key, RequestBlocks.Days ForecastOfDays) 
```

###### Get current or realtime weather data by a searching key value:
```
GetWeatherData(String key, RequestBlocks.GetBy getBy, String value) 
```

###### Get current or realtime weather data by Latitude and longitude:
```
GetWeatherDataByLatLong( String key, String latitude, String longitude) 
```

##### Get current weather data by IP Address:
```
GetWeatherDataByAutoIP(String key) 
```
