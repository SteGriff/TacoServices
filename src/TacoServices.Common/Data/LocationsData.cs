using Newtonsoft.Json;
using System;
using System.Diagnostics;

namespace TacoServices.Common.Data
{
    public class LocationsData
    {
        #region JsonData
        private const string locationsJson =
@"[
  {
    'id': 47,
    'display_name': 'Lakeside Food Court',
    'name': 'Thurrock - Lakeside Shopping Centre',
    'city': 'Essex',
    'postcode': 'RM20 2ZP',
    'store_type': 'Foodcourt',
    'show': false
  },
  {
    'id': 48,
    'display_name': 'Basildon',
    'name': 'Basildon - Eastgate Shopping Centre',
    'city': 'Essex',
    'postcode': 'SS14 1EB',
    'store_type': 'Foodcourt',
	show : false
  },
  {
    'id': 49,
    'display_name': 'Chelmsford',
    'name': 'Chelmsford - Moulsham Street',
    'city': 'Chelmsford',
    'postcode': 'CM2 0LR',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 50,
    'display_name': 'Manchester',
    'name': 'Manchester - Arndale centre',
    'city': 'Manchester',
    'postcode': 'M4 3AQ',
    'store_type': 'Foodcourt',
	show : false
  },
  {
    'id': 51,
    'display_name': 'Ecclesall Road',
    'name': 'Sheffield - Ecclesall Road',
    'city': '',
    'postcode': 'S11 8PP',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 52,
    'display_name': 'Devonshire Street',
    'name': 'Sheffield - Devonshire Street',
    'city': 'Sheffield',
    'postcode': 'S3 7SF',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 53,
    'display_name': 'Barnsley',
    'name': 'Barnsley - Peel Street',
    'city': '',
    'postcode': 'S70 2RL',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 54,
    'display_name': 'Bradford',
    'name': 'Bradford - The Broadway Centre',
    'city': 'Bradford',
    'postcode': 'BD1 1US',
    'store_type': 'Foodcourt',
	show : false
  },
  {
    'id': 55,
    'display_name': 'Nottingham',
    'name': 'Nottingham - Angel Row',
    'city': 'Nottingham',
    'postcode': 'NG1 6HL',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 56,
    'display_name': 'Cleethorpes',
    'name': 'Cleethorpes - Meridian Point Retail Park',
    'city': 'Cleethorpes',
    'postcode': 'DN35 0AQ',
    'store_type': 'Drive Thru',
	show : false
  },
  {
    'id': 57,
    'display_name': 'Colchester',
    'name': 'Colchester - Head Street',
    'city': 'Essex, ',
    'postcode': 'CO1 1NY',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 58,
    'display_name': 'Manvers Way',
    'name': 'Rotherham - Manvers Way',
    'city': 'Wath Upon Dearne',
    'postcode': 'S63 7DQ',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 59,
    'display_name': 'Southampton',
    'name': 'Southampton - Hanover Buildings',
    'city': 'Southampton',
    'postcode': 'SO14 1JU',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 60,
    'display_name': 'Fitzwilliam',
    'name': 'Rotherham - Fitzwilliam',
    'city': 'Rotherham',
    'postcode': 'S65 1EN',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 61,
    'display_name': 'Poole',
    'name': 'Poole - High Street',
    'city': 'Dorset',
    'postcode': 'BH15 1AS',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 62,
    'display_name': 'Chichester',
    'name': 'Chichester - Chichester Gate Leisure Park',
    'city': 'Chichester',
    'postcode': 'PO19 8EL',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 64,
    'display_name': 'Woking',
    'name': 'Woking - Chertsey Road',
    'city': 'Woking',
    'postcode': 'Gu21 5ab',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 65,
    'display_name': 'Rockingham',
    'name': 'Barnsley - Rockingham',
    'city': 'Barnsley',
    'postcode': 'S70 5TW',
    'store_type': 'Drive Thru',
	show : false
  },
  {
    'id': 66,
    'display_name': 'Broughton Lane',
    'name': 'Sheffield - Broughton Lane',
    'city': 'Sheffield',
    'postcode': 'S9 2DD',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 67,
    'display_name': 'Glasgow',
    'name': 'Glasgow - Sauchiehall Street',
    'city': 'Glasgow',
    'postcode': 'G2 3EZ',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 68,
    'display_name': 'York',
    'name': 'York - Monks Cross Drive',
    'city': 'York',
    'postcode': 'YO32 9GZ',
    'store_type': 'Drive Thru',
	show : false
  },
  {
    'id': 69,
    'display_name': 'Brighton',
    'name': 'Brighton - Western Road',
    'city': 'Brighton',
    'postcode': 'BN1 2LB',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 70,
    'display_name': 'Liverpool',
    'name': 'Liverpool - Bold Street',
    'city': 'Liverpool',
    'postcode': 'L1 4DS',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 71,
    'display_name': 'Bournemouth',
    'name': 'Bournemouth - Old Christchurch Road',
    'city': 'Bournemouth',
    'postcode': 'BH1 1NL',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 73,
    'display_name': 'Leeds',
    'name': 'Leeds - St Johns Centre',
    'city': 'Leeds',
    'postcode': 'LS2 8LQ',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 74,
    'display_name': 'Manchester',
    'name': 'Manchester - Deansgate',
    'city': 'Manchester',
    'postcode': 'M3 2AY',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 75,
    'display_name': 'Tower Park',
    'name': 'Poole - Tower Park',
    'city': 'Poole',
    'postcode': 'BH12 4NY',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 76,
    'display_name': 'Frenchgate',
    'name': 'Doncaster - Frenchgate',
    'city': 'Doncaster',
    'postcode': 'DN1 1SW',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 77,
    'display_name': 'Hammersmith',
    'name': 'London - Hammersmith',
    'city': 'Hammersmith',
    'postcode': 'W6 0QW',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 78,
    'display_name': 'Holborn',
    'name': 'London - Holborn',
    'city': 'Bloomsbury',
    'postcode': 'WC1B 4ET',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 79,
    'display_name': 'Great Yarmouth',
    'name': 'Great Yarmouth',
    'city': 'Great Yarmouth',
    'postcode': 'NR30 2AB',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 80,
    'display_name': 'Irvine',
    'name': 'Irvine - Riverway Retail Park',
    'city': 'Irvine',
    'postcode': 'KA12 8AG',
    'store_type': 'Drive Thru',
	show : false
  },
  {
    'id': 81,
    'display_name': 'Portsmouth',
    'name': 'Portsmouth - Commercial Road',
    'city': 'Portsmouth',
    'postcode': 'PO1 4BJ',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 82,
    'display_name': 'Croydon',
    'name': 'Croydon - George Street',
    'city': 'Croydon',
    'postcode': 'CR0 1PB',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 83,
    'display_name': 'Grainger Street',
    'name': 'Newcastle - Grainger - Street',
    'city': 'Newcastle',
    'postcode': 'NE1 5JQ',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 84,
    'display_name': 'Fulham',
    'name': 'Fulham - Fulham Broadway',
    'city': 'Fulham',
    'postcode': 'SW6 1AE',
    'store_type': 'Inline',
	show : false
  },
  {
    'id': 85,
    'display_name': 'Fulham',
    'name': 'London - Fulham',
    'city': 'Fulham',
    'postcode': 'SW6 1AE',
    'store_type': 'Inline',
	show : false
  }
]";
        #endregion JsonData

        public LocationCollection GetLocations()
        {
            LocationCollection data = null;

            try
            {
                data = JsonConvert.DeserializeObject<LocationCollection>(locationsJson);
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }

            return data;
        }
    }
}
