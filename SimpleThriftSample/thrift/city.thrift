namespace java io.delta.beans.thrift.generated
namespace csharp io.delta

struct City {
	1: required i64 id;
	2: required string name;
	3: required string countryCode;
 	4: required bool enabled;
 	5: optional i32 displayOrder;
}