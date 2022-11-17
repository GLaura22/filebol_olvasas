# filebol_olvasas

az eredeti kodot irtam mindig at:
  eloszor csak mentes idejet mertem
  aztan a fajlbol olvasaset
  vegul a modositaset (kommentek nelkul most ez a kod fut)
  
  
C# konvenciók:

- use pascal casing when naming a class, record or struct (PascalCasing)
- use PscalCasing  with an I prefix when naming an interface (clarifies that it's an interface)
- when naming public members of types (fields, properties, events, methods, local functions) use pascal casing.
- when writing positional records use pascal casing for parameters 

- use camel casing ("camelCasing") when naming private or internal fields and prefix them with _
- when working with static fields that are private or internal, use the s_ prefix and for thread static use t_
- ```
     public class DataService
        {
            private static IWorkerQueue s_workerQueue;

            [ThreadStatic]
            private static TimeSpan t_timeSpan;
        }
   ```
- writing method parameter --> camel casing
- use implicit typing for local variables
- don't use var when the type is not apparent from the right side of the assignment don't assume the type is clear from a method name 
