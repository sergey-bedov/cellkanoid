﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using SB.Controllers;

public class LevelInfoPanel : MonoBehaviour
{
	public Text LevelNumber;
	public Text LevelName;
	public Text LevelDesc;

	public Text Score;
	public Text RecordScore;
	public Text Lives;

	#region Papulate methods
	public void PapulatePanel(int num, string name, string desc)
	{
		LevelNumber.text = num.ToString();
		if (LevelName)
			LevelName.text = name;
		if (LevelDesc != null) LevelDesc.text = desc;
	}
	public void PapulatePanel(Level level)
	{
		PapulatePanel(level.Number, level.Name, level.Descripton);
	}
	void Start()
	{
		PapulatePanel(LevelController.Get().GetCurLevel());
	}
	#endregion
}