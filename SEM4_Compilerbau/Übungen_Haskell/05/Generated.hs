ClassFile {
    magic = Magic,
    minver = MinorVersion {
        numMinVer = 0
    },
    maxver = MajorVersion {
        numMaxVer = 55
    },
    count_cp = 18,
    array_cp = [
        MethodRef_Info {
            tag_cp = TagMethodRef,
            index_name_cp = 4,
            index_nameandtype_cp = 14,
            desc = ""
        },
        MethodRef_Info {
            tag_cp = TagMethodRef,
            index_name_cp = 3,
            index_nameandtype_cp = 15,
            desc = ""
        },
        Class_Info {
            tag_cp = TagClass,
            index_cp = 16,
            desc = ""
        },
        Class_Info {
            tag_cp = TagClass,
            index_cp = 17,
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 6,
            cad_cp = "<init>",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 3,
            cad_cp = "()V",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 4,
            cad_cp = "Code",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 15,
            cad_cp = "LineNumberTable",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 3,
            cad_cp = "ggT",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 5,
            cad_cp = "(II)I",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 13,
            cad_cp = "StackMapTable",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 10,
            cad_cp = "SourceFile",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 8,
            cad_cp = "ggt.java",
            desc = ""
        },
        NameAndType_Info {
            tag_cp = TagNameAndType,
            index_name_cp = 5,
            index_descr_cp = 6,
            desc = ""
        },
        NameAndType_Info {
            tag_cp = TagNameAndType,
            index_name_cp = 9,
            index_descr_cp = 10,
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 3,
            cad_cp = "ggt",
            desc = ""
        },
        Utf8_Info {
            tag_cp = TagUtf8,
            tam_cp = 16,
            cad_cp = "java/lang/Object",
            desc = ""
        }
    ],
    acfg = AccessFlags [1,32],
    this = ThisClass {
        index_th = 3
    },
    super = SuperClass {
        index_sp = 4
    },
    count_interfaces = 0,
    array_interfaces = [],
    count_fields = 0,
    array_fields = [],
    count_methods = 2,
    array_methods = [
        Method_Info {
            af_mi = AccessFlags [1],
            index_name_mi = 5,
            index_descr_mi = 6,
            tam_mi = 1,
            array_attr_mi = [
                AttributeCode {
                    index_name_attr = 7,
                    tam_len_attr = 29,
                    len_stack_attr = 1,
                    len_local_attr = 1,
                    tam_code_attr = 5,
                    array_code_attr = [
                        42,183,0,1,177
                    ],
                    tam_ex_attr = 0,
                    array_ex_attr = [],
                    tam_atrr_attr = 1,
                    array_attr_attr = [
                        AttributeLineNumberTable {
                            index_name_attr = 8,
                            tam_len_attr = 6,
                            tam_table_attr = 1,
                            array_line_attr = [(0,1)]
                        }
                    ]
                }
            ]
        },
        Method_Info {
            af_mi = AccessFlags [8],
            index_name_mi = 9,
            index_descr_mi = 10,
            tam_mi = 1,
            array_attr_mi = [
                AttributeCode {
                    index_name_attr = 7,
                    tam_len_attr = 78,
                    len_stack_attr = 10,
                    len_local_attr = 2,
                    tam_code_attr = 35, -- 28
                    array_code_attr = [
                        -- Anfang Code von uns
                        26,  -- iload_0 (0x1a)
                        3,   -- iconst_0
                        163, -- icmpgt
                        0,   -- branchbyte1
                        5,   -- branchbyte2
                        2,   -- iconst_m1
                        172, -- ireturn (0xac)
                        -- Ende Code von uns

                        26,  -- iload_0 (0x1a)
                        27,  -- iload_1 (0x1b)
                        160, -- if_icmpne (0xa0)
                        0,   -- branchbyte 1
                        5,   -- branchbyte 2
                        26,  -- iload_0 (0x1a)
                        172, -- ireturn (0xac)
                        26,  -- iload_0 (0x1a)
                        27,  -- iload_1 (0x1b)
                        164, -- if_icmple (0xa4)
                        0,   -- branchbyte1
                        11,  -- branchbyte2
                        26,  -- iload_0 (0x1a)
                        27,  -- iload_1 (0x1b)
                        100, -- isub
                        27,  -- iload_1 (0x1b)
                        184, -- invokestatic
                        0,   -- indexbyte1
                        2,   -- indexbyte2
                        172, -- ireturn
                        27,  -- iload_1
                        26,  -- iload_0
                        100, -- isub
                        26,  -- iload_0
                        184, -- Methodenaufruf??
                        0,   -- indexbyte1
                        2,   -- indexbyte2
                        172  -- ireturn
                    ],
                    tam_ex_attr = 0,
                    array_ex_attr = [],
                    tam_atrr_attr = 2,
                    array_attr_attr = [
                        AttributeLineNumberTable {
                            index_name_attr = 8,
                            tam_len_attr = 22,
                            tam_table_attr = 5,
                            array_line_attr = [(0,3),(5,4),(7,6),(12,7),(20,9)]
                        },
                        AttributeGeneric {
                            index_name_attr = 11,
                            tam_len_attr = 4,
                            rest_attr = "UL\STX\a\f"
                        }
                    ]
                }
            ]
        }
    ],
    count_attributes = 1,
    array_attributes = [
        AttributeSourceFile {
            index_name_attr = 12,
            tam_len_attr = 2,
            index_src_attr = 13
        }
    ]
}