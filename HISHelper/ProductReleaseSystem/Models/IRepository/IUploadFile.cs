﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductReleaseSystem.ProductRelease;
namespace ProductReleaseSystem.Models.IRepository
{
    public partial interface IUploadFile
    {
        /// <summary>
        /// 添加产品
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        bool addProduct(Products products);

        /// <summary>
        /// 添加版本
        /// </summary>
        /// <param name="versions"></param>
        /// <returns></returns>
        bool addVersions(Versions versions);
        
        /// <summary>
        /// 添加文件
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        bool addFiles(Files files);
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="departmentName">部门名称</param>
        /// <returns></returns>
        bool AddDepartment(string departmentName);
        /// <summary>
        /// 查询所有部门
        /// </summary>
        /// <returns></returns>
        List<Dictionary<string, dynamic>> QueryDepartments();


        #region  维护开发人员信息
        /// <summary>
        /// 添加人员
        /// </summary>
        /// <returns></returns>
        bool AddPerson(Developers developer);

        /// <summary>
        /// 获取开发人员信息
        /// </summary>
        /// <param name="departmentID">部门ID</param>
        /// <returns></returns>
        List<Dictionary<string,dynamic>> QueryDevelopers();

        /// <summary>
        /// 修改开发人员信息
        /// </summary>
        /// <param name="departmentID">部门ID</param>
        /// <returns></returns>
        bool UpdateDeveloper(Developers developer);
        /// <summary>
        /// 删除开发人员信息
        /// </summary>
        /// <param name="departmentID">部门ID</param>
        /// <returns></returns>
        bool DeleteDeveloper(int departmentID);


        #endregion

        #region 维护用户表
        /// <summary>
        /// 增加用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        bool AddUser(Users user);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <returns></returns>
        bool UpdataUser(Users user);

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        bool DeleteUser(int id);

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <returns></returns>
         List<Dictionary<string,dynamic>> QueryUsers();
        #endregion
    }
}
