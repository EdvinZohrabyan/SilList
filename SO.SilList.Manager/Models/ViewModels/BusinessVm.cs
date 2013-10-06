﻿using SO.SilList.Manager.Models.ValueObjects;
using SO.SilList.Utility.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.SilList.Manager.Models.ViewModels
{
    public class BusinessVm
    {
        public List<BusinessVo> result { get; set; }
        public string keyword { get; set; }
        public int? pageNumber { get; set; }

        [DisplayName("isActive: ")]
        public bool? isActive { get; set; }

        public int totalCount { get; set; }

        public List<ImageCheckBoxInfo> imagesToRemove { get; set; }
        public BusinessVo business { get; set; }

        public int skip
        {
            get
            {
                if (pageNumber == null || pageNumber < 2 || maxRowCount < 1) return 0;

                return ((int)(pageNumber - 1) * maxRowCount);
            }
        }

        public int maxRowCount
        {
            get
            {
                return 30;
            }
        }

        public BusinessVm()
        {
            this.result = new List<BusinessVo>();
        }

        public void AddBusinessImageInfo(ImageVo businessImageVo, bool isChecked = true)
        {
            if (imagesToRemove == null)
            {
                imagesToRemove = new List<ImageCheckBoxInfo>();
            }
            ImageCheckBoxInfo busnessImgInfo = new ImageCheckBoxInfo(businessImageVo.imageId.ToString(), businessImageVo.url);
            imagesToRemove.Add(busnessImgInfo);
        }


    }
}
