﻿using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Paroxe.PdfRenderer.Internal.Viewer
{
    public class PDFViewerInternal : UIBehaviour
    {
        [SerializeField] public RectTransform m_DownloadDialog;
        [SerializeField] public Text m_DownloadSourceLabel;
        [SerializeField] public bool m_DrawDefaultInspector = false;
        [SerializeField] public RectTransform m_HorizontalScrollBar;
        [SerializeField] public Image m_InvalidPasswordImage;
        [SerializeField] public PDFViewerLeftPanel m_LeftPanel = null;
        [SerializeField] public CanvasGroup m_Overlay;
        [SerializeField] public RectTransform m_PageContainer;
        [SerializeField] public Text m_PageCountLabel;
        [SerializeField] public Button m_PageDownButton;
        [SerializeField] public InputField m_PageInputField;
        [SerializeField] public RawImage m_PageSample;
        [SerializeField] public Button m_PageUpButton;
        [SerializeField] public Text m_PageZoomLabel;
        [SerializeField] public RectTransform m_PasswordDialog;
        [SerializeField] public InputField m_PasswordInputField;
        [SerializeField] public Text m_ProgressLabel;
        [SerializeField] public RectTransform m_ProgressRect;
        [SerializeField] public RectTransform m_ScrollCorner;
        [SerializeField] public ScrollRect m_ScrollRect;
        [SerializeField] public RectTransform m_TopPanel;
        [SerializeField] public RectTransform m_VerticalScrollBar;
        [SerializeField] public RectTransform m_Viewport;
        [SerializeField] public RectTransform m_SearchPanel;
#if UNITY_EDITOR
        [SerializeField] public bool m_BannerIsOpened = true;
        [SerializeField] public bool m_UiShowLoadOptions = true;
        [SerializeField] public bool m_UiShowPasswordOptions = true;
        [SerializeField] public bool m_UiShowViewerSettings = true;
        [SerializeField] public bool m_UiShowSearchSettings = true;
        [SerializeField] public bool m_UiShowOtherSettings = true;
        [SerializeField] public bool m_UiShowRenderSettings = true;
        [SerializeField] public bool m_UiShowDebugSettings = true;
#endif
        public PDFViewer m_PDFViewer = null;
        [SerializeField] private GameObject selectionScreen;
        [SerializeField] private GameObject pdfScreen;
        [SerializeField] private Manager manager;
        public void ClosePdf()
        {
            pdfScreen.SetActive(false);
        }
        public void OpenPdf()
        {
            pdfScreen.SetActive(true);
        }
        public void OpenSelectScreen()
        {
            selectionScreen.SetActive(true);
            manager.ClearItems();
            manager.SetupPdfs();
        }
        public void OnDownloadCancelButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.OnDownloadCancelButtonClicked();
            }
        }

        public void OnNextPageButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.GoToNextPage();
            }
        }

        public void OnPageIndexEditEnd()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.OnPageEditEnd();
            }
        }

        public void OnPasswordDialogCancelButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.OnPasswordDialogCancelButtonClicked();
            }
        }

        public void OnPasswordDialogOkButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.OnPasswordDialogOkButtonClicked();
            }
        }

        public void OnPreviousPageButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.GoToPreviousPage();
            }
        }

        public void OnZoomInButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.ZoomIn();
            }
        }

        public void OnZoomOutButtonClicked()
        {
            if (m_PDFViewer != null)
            {
                m_PDFViewer.ZoomOut();
            }
        }
    }
}