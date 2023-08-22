import {v4} from 'uuid'

const addressArr = [
    '10 Main St, New York City, USA',
    '25 Elm St, Paris, France',
    '205 Oak Ave, Tokyo, Japan',
    '47 Maple St, London, United Kingdom',
    '150 Cedar Rd, Beijing, China',
    '89 Pine Ave, Sydney, Australia',
    '312 Oak St, Rome, Italy',
    '73 Elm Rd, Rio de Janeiro, Brazil',
    '58 Maple Ave, Cairo, Egypt',
    '9 Cedar St, Moscow, Russia',
    '120 Pine Rd, Berlin, Germany',
    '32 Oak Ave, Seoul, South Korea',
    '76 Elm St, Istanbul, Turkey',
    '215 Maple Rd, Mexico City, Mexico',
    '19 Cedar Ave, Mumbai, India',
    '87 Pine St, Cape Town, South Africa',
    '225 Oak Rd, Buenos Aires, Argentina',
    '41 Elm Ave, Dubai, United Arab Emirates',
    '104 Maple St, Toronto, Canada',
    '27 Cedar Rd, Barcelona, Spain',
    '198 Pine Ave, Amsterdam, Netherlands',
    '36 Oak St, Jakarta, Indonesia',
    '69 Elm Rd, Vienna, Austria',
    '274 Maple Ave, Athens, Greece',
    '54 Cedar St, Prague, Czech Republic',
    '121 Pine Rd, Stockholm, Sweden',
    '88 Oak Ave, Budapest, Hungary',
    '3 Elm St, Warsaw, Poland',
    '118 Maple Rd, Sydney, Australia',
    '62 Cedar Ave, Lima, Peru',
    '132 Pine St, Santiago, Chile',
    '77 Oak Rd, Bogota, Colombia',
    '223 Elm Ave, Johannesburg, South Africa',
    '12 Maple St, Riyadh, Saudi Arabia',
    '26 Cedar Rd, Kuala Lumpur, Malaysia',
    '191 Pine Ave, Tel Aviv, Israel',
    '38 Oak St, Dublin, Ireland',
    '95 Elm Rd, Oslo, Norway',
    '207 Maple Ave, Helsinki, Finland',
    '45 Cedar St, Bangkok, Thailand',
    '104 Pine Rd, Singapore',
    '9 Oak Ave, Warsaw, Poland',
    '125 Maple St, Lisbon, Portugal',
    '55 Cedar Rd, Brussels, Belgium',
    '213 Pine Ave, Bucharest, Romania',
    '29 Oak St, Manila, Philippines',
    '141 Elm Rd, Kiev, Ukraine',
    '298 Maple Ave, Zagreb, Croatia',
    '57 Cedar St, Belgrade, Serbia',
    '162 Pine Rd, Sofia, Bulgaria'
  ]


  const universitiesArr = [
    'Harvard University',
    'Stanford University',
    'Massachusetts Institute of Technology',
    'University of Cambridge',
    'California Institute of Technology',
    'University of Oxford',
    'University of Chicago',
    'Princeton University',
    'Yale University',
    'Columbia University',
    'University of Pennsylvania',
    'University College London',
    'Cornell University',
    'University of California, Berkeley',
    'University of California, Los Angeles',
    'Imperial College London',
    'University of Michigan',
    'University of Toronto',
    'ETH Zurich - Swiss Federal Institute of Technology',
    'Peking University'
  ]
  let getUni = ()=>{
    return universitiesArr[Math.floor(Math.random()*18)]
  }
  const homeIdArr = [
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
  ]
  const ownerIdArr = [
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
    v4(),
  ]
  var monthNames = [
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December",
  ];
  var monthShortNames = [
    "Jan",
    "Feb",
    "Mar",
    "Apr",
    "May",
    "Jun",
    "Jul",
    "Aug",
    "Sep",
    "Oct",
    "Nov",
    "Dec",
  ];
  var dateInString =  Array.from({ length: 31 }, (_, index) => {
    const day = index + 1;
    return day < 10 ? `0${day}` : `${day}`;
  });
  const citiesByLetter = {
    a: ['Amsterdam', 'Australia', 'Atlanta', 'Auckland', 'Austin'],
    b: ['Berlin', 'Barcelona', 'Bangkok', 'Beijing', 'Brisbane'],
    c: ['Chicago', 'Cairo', 'Copenhagen', 'Cape Town', 'Calgary'],
    d: ['Dublin', 'Delhi', 'Denver', 'Dresden', 'Dubai'],
    e: ['Europe', 'Eindhoven', 'El Paso', 'Edmonton', 'Exeter'],
    f: ['Florence', 'Frankfurt', 'Fukuoka', 'Fuzhou', 'Fortaleza'],
    g: ['Geneva', 'Guangzhou', 'Gothenburg', 'Galway', 'Glasgow'],
    h: ['Helsinki', 'Hamburg', 'Hanoi', 'Havana', 'Houston'],
    i: ['Istanbul', 'Italy', 'Indianapolis', 'Irvine', 'Ibiza'],
    j: ['Jerusalem', 'Johannesburg', 'Jakarta', 'Jeddah', 'Juneau'],
    k: ['Kyoto', 'Kuala Lumpur', 'Kansas City', 'Krakow', 'Kingston'],
    l: ['London', 'Los Angeles', 'Lisbon', 'Lima', 'Lyon'],
    m: ['Madrid', 'Mumbai', 'Moscow', 'Munich', 'Manila'],
    n: ['New York', 'Nairobi', 'Naples', 'Nantes', 'Nashville'],
    o: ['Oslo', 'Ottawa', 'Orlando', 'Osaka', 'Odessa'],
    p: ['Paris', 'Prague', 'Perth', 'Portland', 'Phuket'],
    q: ['Quebec City', 'Quito', 'Qingdao', 'Queenstown', 'Quanzhou'],
    r: ['Rome', 'Rio de Janeiro', 'Reykjavik', 'Rotterdam', 'Riga'],
    s: ['Sydney', 'South Korea', 'Shanghai', 'South America', 'San Francisco'],
    t: ['Tokyo', 'Thailand', 'Taipei', 'Tehran', 'Toulouse'],
    u: ['United States', 'United Kingdom', 'Udine', 'Uppsala', 'Ushuaia'],
    v: ['Venice', 'Vienna', 'Vancouver', 'Valencia', 'Verona'],
    w: ['Warsaw', 'Wellington', 'Washington D.C.', 'Wuhan', 'Wroclaw'],
    x: ['Xiamen', 'Xi\'an', 'Xianyang', 'Xining', 'Xalapa'],
    y: ['York', 'Yogyakarta', 'Yokohama', 'Yerevan', 'Yinchuan'],
    z: ['Zurich', 'Zagreb', 'Zhanjiang', 'Zamboanga', 'Zhengzhou']
  };

  export default {
    addressArr: addressArr,
    getUni:getUni,
    homeIdArr:homeIdArr,
    ownerIdArr:ownerIdArr,
    monthNames:monthNames,
    monthShortNames:monthShortNames,
    citiesByLetter:citiesByLetter,
    dateInString:dateInString
    
  }