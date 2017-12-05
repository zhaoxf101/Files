class RegionInfo
{
    public string Category { get; set; }

    public ProvinceInfo[] Provinces { get; set; }
}

class ProvinceInfo
{
    public string Province { get; set; }

    public string[] Cities { get; set; }
}

static RegionInfo[] _Regions = new RegionInfo[]
{
            new RegionInfo
            {
                Category = "华北地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "北京",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "天津",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "河北",
                        Cities = new[] {
                            "石家庄", "保定", "沧州", "承德", "邯郸",
                            "衡水", "廊坊", "秦皇岛", "唐山", "邢台",
                            "张家口"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "山西",
                        Cities = new[] {
                            "太原", "长治", "大同", "晋城", "晋中",
                            "临汾", "吕梁", "朔州", "忻州", "阳泉",
                            "运城"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "内蒙古",
                        Cities = new[] {
                            "呼和浩特", "阿拉善盟", "巴彦淖尔", "包头", "赤峰",
                            "鄂尔多斯", "呼伦贝尔", "通辽", "乌海", "乌兰察布",
                            "锡林郭勒盟", "兴安盟"
                        }
                    }
                },
            },
            new RegionInfo
            {
                Category = "东北地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "辽宁",
                        Cities = new[] {
                            "沈阳", "鞍山", "本溪", "朝阳", "大连",
                            "丹东", "抚顺", "阜新", "葫芦岛", "锦州",
                            "辽阳", "盘锦", "铁岭", "营口"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "吉林",
                        Cities = new[] {
                            "长春", "白城", "白山", "吉林", "辽源",
                            "四平", "松原", "通化", "延边"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "黑龙江",
                        Cities = new[] {
                            "哈尔滨", "大庆", "大兴安岭", "鹤岗", "黑河",
                            "鸡西", "佳木斯", "牡丹江", "齐齐哈尔", "七台河",
                            "双鸭山", "绥化", "伊春"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "华东地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "上海",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "江苏",
                        Cities = new[] {
                            "南京", "常州", "淮安", "连云港", "南通",
                            "宿迁", "苏州", "泰州", "无锡", "徐州",
                            "盐城", "扬州", "镇江"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "浙江",
                        Cities = new[] {
                            "杭州", "湖州", "嘉兴", "金华", "丽水",
                            "宁波", "衢州", "绍兴", "台州", "温州",
                            "舟山"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "安徽",
                        Cities = new[] {
                            "合肥", "安庆", "蚌埠", "亳州", "巢湖",
                            "池州", "滁州", "阜阳", "淮北", "淮南",
                            "黄山", "六安", "马鞍山", "宿州", "铜陵",
                            "芜湖", "宣城"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "福建",
                        Cities = new[] {
                            "福州", "龙岩", "南平", "宁德", "莆田",
                            "泉州", "三明", "厦门", "漳州"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "江西",
                        Cities = new[] {
                            "南昌", "抚州", "赣州", "吉安", "景德镇",
                            "九江", "萍乡", "上饶", "新余", "宜春",
                            "鹰潭"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "山东",
                        Cities = new[] {
                            "济南", "滨州", "德州", "东营", "菏泽",
                            "济宁", "莱芜", "聊城", "临沂", "青岛",
                            "日照", "泰安", "潍坊", "威海", "烟台",
                            "枣庄", "淄博"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "华中地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "河南",
                        Cities = new[] {
                            "郑州", "安阳", "鹤壁", "济源", "焦作",
                            "开封", "漯河", "洛阳", "南阳", "平顶山",
                            "濮阳", "三门峡", "商丘", "新乡", "信阳",
                            "许昌", "周口", "驻马店"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "湖北",
                        Cities = new[] {
                            "武汉", "鄂州", "恩施", "黄冈", "黄石",
                            "荆门", "荆州", "潜江", "神农架", "十堰",
                            "随州", "天门", "咸宁", "仙桃", "襄阳",
                            "孝感", "宜昌"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "湖南",
                        Cities = new[] {
                            "长沙", "常德", "郴州", "衡阳", "怀化",
                            "娄底", "邵阳", "湘潭", "湘西", "益阳",
                            "永州", "岳阳", "张家界", "株洲"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "华南地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "广东",
                        Cities = new[] {
                            "广州", "潮州", "东莞", "佛山", "河源",
                            "惠州", "江门", "揭阳", "茂名", "梅州",
                            "清远", "汕头", "汕尾", "韶关", "深圳",
                            "阳江", "云浮", "湛江", "肇庆", "中山",
                            "珠海"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "海南",
                       Cities = new[] {
                            "海口", "白沙黎族自治县", "保亭黎族苗族自治县", "昌江黎族自治县", "澄迈县",
                            "儋州", "定安县", "东方", "乐东黎族自治县", "临高县",
                            "陵水黎族自治县", "琼海", "琼中黎族苗族自治县", "三亚", "屯昌县",
                            "万宁", "文昌", "五指山"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "广西",
                        Cities = new[] {
                            "南宁", "百色", "北海", "崇左", "防城港",
                            "贵港", "桂林", "河池", "贺州", "来宾",
                            "柳州", "钦州", "梧州", "玉林"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "西南地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "重庆",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "四川",
                        Cities = new[] {
                            "成都", "阿坝", "巴中", "达州", "德阳",
                            "甘孜", "广安", "广元", "乐山", "凉山",
                            "泸州", "眉山", "绵阳", "南充", "内江",
                            "攀枝花", "遂宁", "雅安", "宜宾", "自贡",
                            "资阳"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "贵州",
                        Cities = new[] {
                            "贵阳", "安顺", "毕节", "六盘水", "黔东南",
                            "黔南", "黔西南", "铜仁", "遵义"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "云南",
                        Cities = new[] {
                            "昆明", "保山", "楚雄", "大理", "德宏",
                            "迪庆", "红河", "丽江", "临沧", "怒江",
                            "普洱", "曲靖", "文山", "西双版纳", "玉溪",
                            "昭通"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "西藏",
                        Cities = new[] {
                            "拉萨", "阿里", "昌都", "林芝", "那曲",
                            "日喀则", "山南"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "西北地区",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "陕西",
                        Cities = new[] {
                            "西安", "安康", "宝鸡", "汉中", "商洛",
                            "铜川", "渭南", "咸阳", "延安", "榆林"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "甘肃",
                        Cities = new[] {
                            "兰州", "白银", "定西", "甘南", "嘉峪关",
                            "金昌", "酒泉", "临夏", "陇南", "平凉",
                            "庆阳", "天水", "武威", "张掖"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "青海",
                        Cities = new[] {
                            "西宁", "果洛", "海北", "海东", "海南",
                            "海西", "黄南", "玉树"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "宁夏",
                        Cities = new[] {
                            "银川", "固原", "石嘴山", "吴忠", "中卫"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "新疆",
                        Cities = new[] {
                            "乌鲁木齐", "阿克苏", "阿拉尔", "阿勒泰", "巴音郭楞",
                            "博尔塔拉", "昌吉", "哈密", "和田", "喀什",
                            "克拉玛依", "克孜勒苏柯尔克孜", "石河子", "塔城", "图木舒克",
                            "吐鲁番", "五家渠", "伊犁"
                        }
                    }
                }
            }
};
