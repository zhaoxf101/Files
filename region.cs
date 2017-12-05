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
                Category = "��������",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "���",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "�ӱ�",
                        Cities = new[] {
                            "ʯ��ׯ", "����", "����", "�е�", "����",
                            "��ˮ", "�ȷ�", "�ػʵ�", "��ɽ", "��̨",
                            "�żҿ�"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "ɽ��",
                        Cities = new[] {
                            "̫ԭ", "����", "��ͬ", "����", "����",
                            "�ٷ�", "����", "˷��", "����", "��Ȫ",
                            "�˳�"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "���ɹ�",
                        Cities = new[] {
                            "���ͺ���", "��������", "�����׶�", "��ͷ", "���",
                            "������˹", "���ױ���", "ͨ��", "�ں�", "�����첼",
                            "���ֹ�����", "�˰���"
                        }
                    }
                },
            },
            new RegionInfo
            {
                Category = "��������",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "��ɽ", "��Ϫ", "����", "����",
                            "����", "��˳", "����", "��«��", "����",
                            "����", "�̽�", "����", "Ӫ��"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "�׳�", "��ɽ", "����", "��Դ",
                            "��ƽ", "��ԭ", "ͨ��", "�ӱ�"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "������",
                        Cities = new[] {
                            "������", "����", "���˰���", "�׸�", "�ں�",
                            "����", "��ľ˹", "ĵ����", "�������", "��̨��",
                            "˫Ѽɽ", "�绯", "����"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "��������",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "�Ϻ�",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "�Ͼ�", "����", "����", "���Ƹ�", "��ͨ",
                            "��Ǩ", "����", "̩��", "����", "����",
                            "�γ�", "����", "��"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "�㽭",
                        Cities = new[] {
                            "����", "����", "����", "��", "��ˮ",
                            "����", "����", "����", "̨��", "����",
                            "��ɽ"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "�Ϸ�", "����", "����", "����", "����",
                            "����", "����", "����", "����", "����",
                            "��ɽ", "����", "��ɽ", "����", "ͭ��",
                            "�ߺ�", "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "����", "��ƽ", "����", "����",
                            "Ȫ��", "����", "����", "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "�ϲ�", "����", "����", "����", "������",
                            "�Ž�", "Ƽ��", "����", "����", "�˴�",
                            "ӥ̶"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "ɽ��",
                        Cities = new[] {
                            "����", "����", "����", "��Ӫ", "����",
                            "����", "����", "�ĳ�", "����", "�ൺ",
                            "����", "̩��", "Ϋ��", "����", "��̨",
                            "��ׯ", "�Ͳ�"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "���е���",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "֣��", "����", "�ױ�", "��Դ", "����",
                            "����", "���", "����", "����", "ƽ��ɽ",
                            "���", "����Ͽ", "����", "����", "����",
                            "���", "�ܿ�", "פ���"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "�人", "����", "��ʩ", "�Ƹ�", "��ʯ",
                            "����", "����", "Ǳ��", "��ũ��", "ʮ��",
                            "����", "����", "����", "����", "����",
                            "Т��", "�˲�"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "��ɳ", "����", "����", "����", "����",
                            "¦��", "����", "��̶", "����", "����",
                            "����", "����", "�żҽ�", "����"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "���ϵ���",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "�㶫",
                        Cities = new[] {
                            "����", "����", "��ݸ", "��ɽ", "��Դ",
                            "����", "����", "����", "ï��", "÷��",
                            "��Զ", "��ͷ", "��β", "�ع�", "����",
                            "����", "�Ƹ�", "տ��", "����", "��ɽ",
                            "�麣"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                       Cities = new[] {
                            "����", "��ɳ����������", "��ͤ��������������", "��������������", "������",
                            "����", "������", "����", "�ֶ�����������", "�ٸ���",
                            "��ˮ����������", "��", "������������������", "����", "�Ͳ���",
                            "����", "�Ĳ�", "��ָɽ"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "��ɫ", "����", "����", "���Ǹ�",
                            "���", "����", "�ӳ�", "����", "����",
                            "����", "����", "����", "����"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "���ϵ���",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new string[0]
                    },
                    new ProvinceInfo
                    {
                        Province = "�Ĵ�",
                        Cities = new[] {
                            "�ɶ�", "����", "����", "����", "����",
                            "����", "�㰲", "��Ԫ", "��ɽ", "��ɽ",
                            "����", "üɽ", "����", "�ϳ�", "�ڽ�",
                            "��֦��", "����", "�Ű�", "�˱�", "�Թ�",
                            "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "��˳", "�Ͻ�", "����ˮ", "ǭ����",
                            "ǭ��", "ǭ����", "ͭ��", "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "��ɽ", "����", "����", "�º�",
                            "����", "���", "����", "�ٲ�", "ŭ��",
                            "�ն�", "����", "��ɽ", "��˫����", "��Ϫ",
                            "��ͨ"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "����", "����", "��֥", "����",
                            "�տ���", "ɽ��"
                        }
                    }
                }
            },
            new RegionInfo
            {
                Category = "��������",
                Provinces = new ProvinceInfo[] {
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "����", "����", "����", "����",
                            "ͭ��", "μ��", "����", "�Ӱ�", "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "����", "����", "����", "������",
                            "���", "��Ȫ", "����", "¤��", "ƽ��",
                            "����", "��ˮ", "����", "��Ҵ"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "�ຣ",
                        Cities = new[] {
                            "����", "����", "����", "����", "����",
                            "����", "����", "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "����",
                        Cities = new[] {
                            "����", "��ԭ", "ʯ��ɽ", "����", "����"
                        }
                    },
                    new ProvinceInfo
                    {
                        Province = "�½�",
                        Cities = new[] {
                            "��³ľ��", "������", "������", "����̩", "��������",
                            "��������", "����", "����", "����", "��ʲ",
                            "��������", "�������տ¶�����", "ʯ����", "����", "ͼľ���",
                            "��³��", "�����", "����"
                        }
                    }
                }
            }
};
